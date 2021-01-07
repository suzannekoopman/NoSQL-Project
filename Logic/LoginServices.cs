using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic
{
    public class LoginServices
    {
        //incomplete, corresponding query not functional yet.
        UserDAL userDal = new UserDAL();
        public string GetPassword(string username)
        {
            return userDal.GetPassword(username);
        }


        public void Sendpassword(string emailadress)
        {
            SendEmailDAL emailsender = new SendEmailDAL();
            emailsender.SendMail($"{emailadress}");
        }

        public string GetSalt(string username)
        {
            return userDal.GetSalt(username);
        }

        public User GetUser(string username)
        {
            return userDal.GetUser(username);
        }
    }
}
