namespace Model
{
    public class User
    {
        public int _id;
        public string firstName;
        public string lastName;
        public PersonType personType;
        public string email;
        public string phone;
        public Location location;
        public string password;
        public string salt;
        public int ticketCount;
        

        public User(int _id, string firstName, string lastName, PersonType personType, string email, string phone,
            Location location, string password, string salt, int ticketCount)
        {
            this._id = _id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.personType = personType;
            this.email = email;
            this.phone = phone;
            this.location = location;
            this.password = password;
            this.salt = salt;
            this.ticketCount = ticketCount;
        }

        public User(string firstName, string lastName, PersonType personType, string email, string phone,
            Location location, string password, string salt)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.personType = personType;
            this.email = email;
            this.phone = phone;
            this.location = location;
            this.password = password;
            this.salt = salt;
        }

        public User(string firstName, string email, string password)
        {
            this.firstName = firstName;
            this.email = email;
            this.password = password;
        }

        public User()
        {
            //empty constructor for DeserializeObject
        }

    }
}
