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
using DAL;

namespace Project_ITSM_4
{
    public partial class UserAdd : Form
    {
        User currentUser;
        UserCRUD userCRUD = new UserCRUD();
        bool taken;
        public UserAdd(User user)
        {
            InitializeComponent();
            currentUser = user;
            btn_AddUser.Enabled = false;
            cb_Type.DataSource = Enum.GetValues(typeof(PersonType));
            cb_Location.DataSource = Enum.GetValues(typeof(Location));
            lbl_Email_Taken.Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            DashboardManager dashboard = new DashboardManager(currentUser);
            dashboard.Show();
            this.Hide();
        }

        private void btn_Incident_Click(object sender, EventArgs e)
        {
            TicketOverview ticketOverview = new TicketOverview(currentUser);
            ticketOverview.Show();
            this.Hide();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            UserOverview userOverview = new UserOverview(currentUser);
            userOverview.Show();
            this.Hide();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            UserOverview userOverview = new UserOverview(currentUser);
            userOverview.Show();
            this.Hide();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            // generate password
            RNG rng = new RNG();
            HashAndSalt hashAndSalt = new HashAndSalt();
            string randomString = rng.GenerateRandomCryptographicKey(8);
            string salt = hashAndSalt.CreateSalt(5);

            // get values
            string firstName = tb_FirstName.Text;
            string lastName = tb_LastName.Text;
            PersonType personType = (PersonType)cb_Type.SelectedItem;
            string email = tb_Email.Text;
            string phone = tb_Phone.Text;
            Location location = (Location)cb_Location.SelectedItem;
            string password = hashAndSalt.GenerateHash(randomString, salt);

            //add user
            userCRUD.WriteNewUser(firstName, lastName, personType, email, phone, location, password, salt);

            // send password
            if (cb_password.Checked)
            {
                LoginServices loginServices = new LoginServices();
                loginServices.Sendpassword(email);
            }

            //confirmation
            MessageBox.Show("New user created");
            UserOverview userOverview = new UserOverview(currentUser);
            userOverview.Show();
            this.Hide();
        }

        private void Enablebutton()
        {
            btn_AddUser.Enabled = (
                !string.IsNullOrEmpty(tb_FirstName.Text) &&
                !string.IsNullOrEmpty(tb_LastName.Text) &&
                !string.IsNullOrEmpty(tb_Email.Text) &&
                !string.IsNullOrEmpty(tb_Phone.Text) &&
                !taken);
        }

        private void tb_FirstName_TextChanged(object sender, EventArgs e)
        {
            Enablebutton();
        }

        private void tb_LastName_TextChanged(object sender, EventArgs e)
        {
            Enablebutton();
        }

        private void tb_Email_TextChanged(object sender, EventArgs e)
        {
            emailTaken();
            Enablebutton();
        }

        private void tb_Phone_TextChanged(object sender, EventArgs e)
        {
            Enablebutton();
        }

        private void emailTaken()
        {
            List<User> users = new List<User>();
            users = userCRUD.ReadUsers();
            foreach (User user in users)
            {
                if (user.email == tb_Email.Text)
                {
                    taken = true;
                    lbl_Email_Taken.Show();
                }
                else
                {
                    taken = false;
                    lbl_Email_Taken.Hide();
                }
            }
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            DashboardManager dbManager = new DashboardManager(currentUser);
            dbManager.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
