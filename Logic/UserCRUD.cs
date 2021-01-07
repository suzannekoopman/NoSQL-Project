using System.Collections.Generic;
using Model;
using DAL;

namespace Logic
{
    public class UserCRUD
    {
        private readonly UserDAL baseConnection = new UserDAL();
        public List<User> ReadUsers()
        {
            return baseConnection.GetAllUsers();
        }
        public bool WriteNewUser(string firstName, string lastName, PersonType personType, string email, string phone, Location location, string password, string salt)
        {
            User newUser = new User(firstName, lastName, personType, email, phone, location, password, salt);
            if (baseConnection.InsertNewUser(newUser))
                return true;
            return false;
        }
        public void DropAllUsers()
        {
            baseConnection.DropAllUsers();
        }
        public bool DeleteUser(string email)
        {
            return baseConnection.DeleteUser(email);
        }

        public string GetSalt(string gebruikersNaam)
        {
            return baseConnection.GetSalt(gebruikersNaam);
        }
    }
}
