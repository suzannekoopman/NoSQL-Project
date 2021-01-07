using System;
using System.Collections.Generic;
using Model;
using DAL;

namespace Logic
{
    public class TicketCRUD
    {
        private readonly TicketDAL baseConnection = new TicketDAL();
        public bool WriteNewTicket(PriorityType priority, DateTime date, string description, TicketStatus status, string solution, string emailAddress)
        {
            Ticket ticket = new Ticket(priority, date, description, status, solution, emailAddress);
            if (baseConnection.NewTicket(ticket))
                return true;
            return false;
        }
        public List<Ticket> GetAllTickets()
        {
            return baseConnection.GetAllTickets();
        }
        public List<Ticket> GetAllTicketsForUser(string emailaddress)
        {
            return baseConnection.GetAllTicketsForUser(emailaddress);
        }
        public void DropAllTickets()
        {
            baseConnection.DropAllTickets();
        }
        public bool ChangeTicketStatus(int ticketId, TicketStatus ticketStatus)
        {
            return baseConnection.ChangeTicketStatus(ticketId, ticketStatus);
        }
        public bool UpdateTicket(Ticket existingTicketWithId)
        {
            //check if the Ticket constructor with a _id is used, otherwise the ticket cannot be updated.
            if (existingTicketWithId._id.ToString() != null)
            {
                return baseConnection.UpdateTicket(existingTicketWithId);
            }
            return false;
        }
        public bool DeleteTicket(int ticketId)
        {
            return baseConnection.DeleteTicket(ticketId);
        }
    }
}
