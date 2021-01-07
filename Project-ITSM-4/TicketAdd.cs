using Model;
using Logic;
using System;
using System.Windows.Forms;

namespace Project_ITSM_4
{
    public partial class TicketAdd : Form
    {
        TicketCRUD ticketCRUD = new TicketCRUD();
        User currentUser;
        public TicketAdd(User user)
        {
            InitializeComponent();
            currentUser = user;
            Priority_ComboBox.DataSource = Enum.GetValues(typeof(PriorityType));
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            if(currentUser.personType == PersonType.Manager)
            {
                DashboardManager dashboard = new DashboardManager(currentUser);
                dashboard.Show();
            }
            else
            {
                DashboardEmployee dashboard = new DashboardEmployee(currentUser);
                dashboard.Show();
            }

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
            TicketOverview ticketOverview = new TicketOverview(currentUser);
            ticketOverview.Show();
            this.Hide();
        }

        private void btn_AddTicket_Click(object sender, EventArgs e)
        {
            Ticket newTicket = new Ticket();
            //User_ComboBox.SelectedItem = newTicket.
            Priority_ComboBox.SelectedItem = newTicket.priority;

            ticketCRUD.WriteNewTicket(newTicket.priority, DateTime.Now, Description_TxtBox.Text, TicketStatus.Open, "To be determined.", currentUser.email);
            this.Hide();
            TicketOverview to = new TicketOverview(currentUser);
            to.Show();
        }

        private void TicketAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            if (currentUser.personType == PersonType.Manager)
            {
                DashboardManager dbManager = new DashboardManager(currentUser);
                dbManager.Show();
            }
            else
            {
                DashboardEmployee dbEmployee = new DashboardEmployee(currentUser);
                dbEmployee.Show();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
