using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        public int _id;
        public PriorityType priority;
        public DateTime date;
        public string description;
        public TicketStatus status;
        public string solution;
        public string emailAddress;
        public Ticket(int _id, PriorityType priority, DateTime date, string description, TicketStatus status, string solution, string emailAddress)
        {
            this._id = _id;
            this.priority = priority;
            this.date = date;
            this.description = description;
            this.status = status;
            this.solution = solution;
            this.emailAddress = emailAddress;
        }
        public Ticket(PriorityType priority, DateTime date, string description, TicketStatus status, string solution, string emailAddress)
        {
            this.priority = priority;
            this.date = date;
            this.description = description;
            this.status = status;
            this.solution = solution;
            this.emailAddress = emailAddress;
        }
        public Ticket()
        {
            //this constructor is made for the deserialization because there is a empty constructor needed
        }
    }
}
