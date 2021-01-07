using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Project_ITSM_4
{
    public partial class TicketOverview : Form
    {
        User currentUser;
        DataTable table;
        public TicketOverview(User user)
        {
            currentUser = user;
            InitializeComponent();
            PopulateDataGridView();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            if (currentUser.personType == PersonType.Manager)
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

        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            UserOverview userOverview = new UserOverview(currentUser);
            userOverview.Show();
            this.Hide();
        }

        private void btn_CreateIncident_Click(object sender, EventArgs e)
        {
            TicketAdd ticketAdd = new TicketAdd(currentUser);
            ticketAdd.Show();
            this.Hide();
        }

        private void PopulateDataGridView()
        {
            TicketCRUD ticketCRUD = new TicketCRUD();
            List<Ticket> tickets = new List<Ticket>();

            if(currentUser.personType == PersonType.Employee || currentUser.personType == PersonType.Customer)
            {
                tickets = ticketCRUD.GetAllTicketsForUser(currentUser.email);
            }
            else
            {
                tickets = ticketCRUD.GetAllTickets();
            }

            table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("User", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Status", typeof(string));
            
            foreach (Ticket ticket in tickets)
            {
                table.Rows.Add(ticket._id, ticket.description, ticket.emailAddress, ticket.date, ticket.status);
            }

            dgv_TicketOverview.DataSource = table;
            dgv_TicketOverview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_TicketOverview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TicketOverview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_TicketOverview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_TicketOverview.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            var box = sender as TextBox;
            dv.RowFilter = "User LIKE '%" + box?.Text + "%'";
            dgv_TicketOverview.DataSource = dv;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
