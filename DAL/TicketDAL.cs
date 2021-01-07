using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Model;
using Newtonsoft.Json;
using System;

namespace DAL
{
    public class TicketDAL : Base
    {
        public bool ChangeTicketStatus(int ticketId, TicketStatus ticketStatus)
        {
            var ticketFilter = Builders<BsonDocument>.Filter.Eq("_id", ticketId);
            try
            {
                tickets.UpdateOne(ticketFilter, Builders<BsonDocument>.Update.Set("status", ticketStatus));
                RefreshTickets();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Ticket> GetAllTicketsForUser(string emailaddress)
        {
            //this function is made for a customer that can only see his own tickets, only load in the tickets from that specific email address
            FilterDefinition<BsonDocument> userFilter = new BsonDocument("emailAddress", emailaddress);
            List<BsonDocument> searchDocuments = tickets.Find(userFilter).ToList();
            if (searchDocuments.Count != 0)
            {
                string json = searchDocuments.ToJson();
                List<Ticket> ticketsFromJSON = JsonConvert.DeserializeObject<List<Ticket>>(json);
                return ticketsFromJSON;
            }
            return new List<Ticket>();
        }
        public bool DeleteTicket(int ticketId)
        {
            try
            {
                var deleteFilter = Builders<BsonDocument>.Filter.Eq("_id", ticketId);
                tickets.DeleteOne(deleteFilter);
                RefreshTickets();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateTicket(Ticket existingTicketWithId)
        {
            var ticketFilter = Builders<BsonDocument>.Filter.Eq("_id", existingTicketWithId._id);
            try
            {
                //update every part of the ticket
                tickets.UpdateOne(ticketFilter, Builders<BsonDocument>.Update.Set("priority", existingTicketWithId.priority));
                tickets.UpdateOne(ticketFilter, Builders<BsonDocument>.Update.Set("date", existingTicketWithId.date));
                tickets.UpdateOne(ticketFilter, Builders<BsonDocument>.Update.Set("description", existingTicketWithId.description));
                tickets.UpdateOne(ticketFilter, Builders<BsonDocument>.Update.Set("status", existingTicketWithId.status));
                tickets.UpdateOne(ticketFilter, Builders<BsonDocument>.Update.Set("solution", existingTicketWithId.solution));
                tickets.UpdateOne(ticketFilter, Builders<BsonDocument>.Update.Set("emailAddress", existingTicketWithId.emailAddress));
                RefreshTickets();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void DropAllTickets()
        {
            DropCollection("tickets");
            RefreshTickets();
        }
        public List<Ticket> GetAllTickets()
        {
            var searchDocuments = tickets.Find(defaultFilter);
            List<BsonDocument> documents = searchDocuments.ToList();
            if (documents.Count != 0)
            {
                string json = documents.ToJson();
                List<Ticket> ticketsFromJSON = JsonConvert.DeserializeObject<List<Ticket>>(json);
                return ticketsFromJSON;
            }
            return null;
        }
        public bool NewTicket(Ticket ticket)
        {
            var findLastDocument = tickets.Find(defaultFilter).Sort(new BsonDocument("_id", -1)).Limit(1);
            //making a transaction query for inserting a new ticket and increasing the ticket count for the user 
            //where in user collection ticket.emailaddress, ticketCount++ is the second query.
            FilterDefinition<BsonDocument> userFilter = new BsonDocument("email", ticket.emailAddress);
            var searchDocuments = users.Find(userFilter);
            BsonDocument currentUser = new BsonDocument();
            int newId;
            try
            {
                currentUser = searchDocuments.First();
            }
            catch (InvalidOperationException e)
            {
                //if there are no tickets yet for the user give back 1 and insert the ticket directly
                newId = 1;
                BsonDocument newDoc = FirstTicketForUser(ticket, newId);
                try
                {
                    tickets.InsertOne(newDoc);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            //here updating the ticketCount
            FilterDefinition<BsonDocument> newUser = Builders<BsonDocument>.Filter.Eq("email", ticket.emailAddress);
            var update = Builders<BsonDocument>.Update.Set("ticketCount", currentUser.GetValue("ticketCount").ToInt32() + 1);
            //grab only the last inserted document.
            BsonDocument lastDocument = findLastDocument.First();
            //if _id doesn't exists if there are no tickets, give back 0 + 1 = 1, this is going to be the first _id then
            newId = lastDocument.GetValue("_id", 0).ToInt32() + 1;
            //db.Tickets.find().sort({"_id" : -1}).limit(1) is the command normally being run in the mongo shell to get the same result.
            BsonDocument doc = FirstTicketForUser(ticket, newId);
            //using a try/catch because InsertOne does not give a boolean back.
            using (var session = client.StartSession())
            {
                //starting the transaction:
                session.StartTransaction();
                try
                {
                    users.UpdateOne(newUser, update);
                    tickets.InsertOne(doc);
                    session.CommitTransaction();
                    RefreshTickets();
                    return true;
                }
                catch
                {
                    session.AbortTransaction();
                    return false;
                }
            }
        }
        private BsonDocument FirstTicketForUser(Ticket ticket, int newId)
        {
            Ticket ticketWithNewId = new Ticket(newId, ticket.priority, ticket.date, ticket.description, ticket.status, ticket.solution, ticket.emailAddress);
            string json = JsonConvert.SerializeObject(ticketWithNewId);
            BsonDocument bsons = BsonDocument.Parse(json);
            return bsons;
        }
    }
}
