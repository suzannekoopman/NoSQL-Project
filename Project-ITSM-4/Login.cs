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
    public partial class Login : Form
    {
        LoginServices loginServices = new LoginServices();
        HashAndSalt hashAndSalt = new HashAndSalt();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            UserCRUD usercrud = new UserCRUD();

            User user = loginServices.GetUser(txt_Username.Text);

            string salt = usercrud.GetSalt(user.email);
            HashAndSalt retrieve = new HashAndSalt();
            string hash = retrieve.GenerateHash(txt_Password.Text, salt);

            if (user == null || txt_Username.Text != user.email)
            {
                MessageBox.Show("Incorrect username");
            }
            else if (user.password != hash)
            {
                MessageBox.Show("Incorrect password, please try again.");
            }
            else
            {

                if (cb_RememberMe.Checked == true)
                {
                    Properties.Settings.Default.Username = txt_Username.Text;
                    Properties.Settings.Default.Password = txt_Password.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Username = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                }

                //user for testing.
                //User testUser = new User("Dan", "Dan@gmail.com", "1234");

                //opening the right dashboard depending on usertype.
                if (user.personType == PersonType.Customer)
                {
                    DashboardEmployee dashboardEmployee = new DashboardEmployee(user);
                    dashboardEmployee.Show();
                    this.Hide();
                }
                else if (user.personType == PersonType.Employee)
                {
                    DashboardEmployee dashboardEmployee = new DashboardEmployee(user);
                    dashboardEmployee.Show();
                    this.Hide();
                }
                else if (user.personType == PersonType.Manager)
                {
                    DashboardManager dashboardManager = new DashboardManager(user);
                    dashboardManager.Show();
                    this.Hide();
                }
                else
                {
                    //legacy code in case it doesn't work. Not final.
                    DashboardEmployee dashboardEmployee = new DashboardEmployee(user);
                    dashboardEmployee.Show();
                    this.Hide();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username != null)
            {
                txt_Username.Text = Properties.Settings.Default.Username;
                txt_Password.Text = Properties.Settings.Default.Password;
            }

            //todo: probeer alle Logic functies uit van de tickets en de users!
            TicketCRUD ticketCRUD = new TicketCRUD();
            UserCRUD userCRUD = new UserCRUD();
            HashAndSalt hashAndSalt = new HashAndSalt();
            string password = hashAndSalt.GenerateHash("tesfdsafdsafdsafdsafdsafdsafsdt", hashAndSalt.CreateSalt(5));//username: test@test.nl
        }

        private void lbl_Forgot_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }

        private void txt_Password_TextChanged_1(object sender, EventArgs e)
        {
            // Change password to asterix
            txt_Password.PasswordChar = '*';
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
