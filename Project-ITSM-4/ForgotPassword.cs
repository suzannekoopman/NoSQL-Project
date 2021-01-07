using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;

namespace Project_ITSM_4
{
    public partial class ForgotPassword : Form
    {
        LoginServices loginServices = new LoginServices();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //todo: probeer alle Logic functies uit van de tickets en de users!
            TicketCRUD ticketCRUD = new TicketCRUD();
            UserCRUD userCRUD = new UserCRUD();
            HashAndSalt hashAndSalt = new HashAndSalt();
            string password = hashAndSalt.GenerateHash("tesfdsafdsafdsafdsafdsafdsafsdt", hashAndSalt.CreateSalt(5));
            //if (userCRUD.WriteNewUser(PersonType.Manager, "test", "test@test.nl", password))
            //{
            //    txt_Username.AppendText("WriteNewUser works");
            //}
            ticketCRUD.GetAllTicketsForUser("test@test.nl");
            //if (ticketCRUD.WriteNewTicket(1, new DateTime(2020, 12, 12), "test for a fix", TicketStatus.Finished, "tried turning a bool from false to true, it worked.", "test@test.nl"))
            //{
            //    txt_Username.AppendText("writeNewTicket works");
            //}
            List<Ticket> tickets = ticketCRUD.GetAllTickets();
        }

        private void btn_Recover_Password_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            //true code.
            //string emailadress = loginServices.GetUserEmail(username);


            //testing purposes only.
            string emailadress = "topdeskgroep5@gmail.com";

            try
            {
                loginServices.Sendpassword(emailadress);
                MessageBox.Show("Mail sent succesfully.");
            }
            catch
            {
                MessageBox.Show("Something went wrong, your mail was not sent.");
            }
        }

        private void pnl_Login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
