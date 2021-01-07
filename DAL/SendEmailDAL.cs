using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace DAL
{
    public class SendEmailDAL
    {
        public void SendMail(string emailadress)
        {
            SmtpClient client = new SmtpClient(ConfigurationManager.ConnectionStrings["smtpServer"].ConnectionString.ToString());
            client.UseDefaultCredentials = false;
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(ConfigurationManager.ConnectionStrings["emailAddress"].ConnectionString.ToString(), ConfigurationManager.ConnectionStrings["emailPassword"].ConnectionString.ToString());

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(ConfigurationManager.ConnectionStrings["emailAddress"].ConnectionString.ToString());
            mailMessage.To.Add($"{emailadress}");
            mailMessage.Body = "test";
            mailMessage.Subject = "test";
            client.Send(mailMessage);
        }
    }
}
