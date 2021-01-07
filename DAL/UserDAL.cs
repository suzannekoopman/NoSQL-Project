using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Model;
using Newtonsoft.Json;

namespace DAL
{
    public class UserDAL : Base
    {
        //beginning for a query to get a password.
        public string GetPassword(string username)
        {
            string json = null;
            try
            {
                var passwordFilter = Builders<BsonDocument>.Filter.Eq("email", username);
                var doc = users.Find(passwordFilter).FirstOrDefault();
                json = doc.ToJson();
            }
            catch
            {
                return null;
            }
            User userFromJSON = JsonConvert.DeserializeObject<User>(json);
            return userFromJSON.password;
        }

        public string GetSalt(string username)
        {
            string json = null;
            try
            {
                var saltFilter = Builders<BsonDocument>.Filter.Eq("email", username);
                var doc = users.Find(saltFilter).FirstOrDefault();
                json = doc.ToJson();
            }
            catch
            {
                return null;
            }
            User userFromJSON = JsonConvert.DeserializeObject<User>(json);
            return userFromJSON.salt;
        }

        public User GetUser(string username)
        {
            string json = null;
            try
            {
                var userFilter = Builders<BsonDocument>.Filter.Eq("email", username);
                var doc = users.Find(userFilter).FirstOrDefault();
                json = doc.ToJson();
            }
            catch
            {
                return null;
            }
            return JsonConvert.DeserializeObject<User>(json);
        }

        public bool DeleteUser(string email)
        {
            try
            {
                var deleteFilter = Builders<BsonDocument>.Filter.Eq("email", email);
                users.DeleteOne(deleteFilter);
                RefreshUsers();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<User> GetAllUsers()
        {
            var searchDocuments = users.Find(defaultFilter);
            //get all the users on the database
            List<BsonDocument> documents = searchDocuments.ToList();
            if (documents.Count != 0)
            {
                string json = documents.ToJson();
                List<User> usersFromJSON = JsonConvert.DeserializeObject<List<User>>(json);
                return usersFromJSON;
            }
            return null;
        }
        public void DropAllUsers()
        {
            DropCollection("Users");
            RefreshUsers();
        }
        public bool InsertNewUser(User user)
        {
            var findLastDocument = users.Find(defaultFilter).Sort(new BsonDocument("_id", -1)).Limit(1);
            int newId;
            try
            {
                //grab only the last inserted document.
                BsonDocument lastDocument = findLastDocument.First();
                //if _id doesn't exists if there are no tickets, give back 0 + 1 = 1, this is going to be the first _id then
                newId = lastDocument.GetValue("_id", 0).ToInt32() + 1;
            }
            catch
            {
                //if the standardvalue of GetValue doesn't work, give back 1 anyway
                newId = 1;
            }
            User userWithNewId = new User(newId, user.firstName, user.lastName, user.personType, user.email, user.phone, user.location, user.password, user.salt, 0);

            string json = JsonConvert.SerializeObject(userWithNewId);
            BsonDocument doc = BsonDocument.Parse(json);
            //using a try/catch because InsertOne does not give a boolean back.
            try
            {
                users.InsertOne(doc);
                RefreshUsers();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
