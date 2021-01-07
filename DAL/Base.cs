using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;

namespace DAL
{
    public abstract class Base
    {
        private IMongoDatabase database;
        protected IMongoCollection<BsonDocument> users;
        protected IMongoCollection<BsonDocument> tickets;
        protected FilterDefinition<BsonDocument> defaultFilter = Builders<BsonDocument>.Filter.Empty;
        protected MongoClient client;

        protected Base()
        {
            //make a new connection and load in the users and tickets collections
            client = new MongoClient(ConfigurationManager.ConnectionStrings["DB"].ConnectionString.ToString());
            database = client.GetDatabase(ConfigurationManager.ConnectionStrings["DBName"].ConnectionString.ToString());
            users = database.GetCollection<BsonDocument>("Users");
            tickets = database.GetCollection<BsonDocument>("Tickets");
        }

        protected void RefreshTickets()
        {
            tickets = database.GetCollection<BsonDocument>("Tickets");
        }
        protected void RefreshUsers()
        {
            users = database.GetCollection<BsonDocument>("Users");
        }
        protected void DropCollection(string collection)
        {
            database.DropCollection(collection);
        }
    }
}
