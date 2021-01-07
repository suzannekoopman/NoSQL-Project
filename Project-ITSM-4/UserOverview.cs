using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;

namespace Project_ITSM_4
{
    public partial class UserOverview : Form
    {
        DataTable table;
        User currentUser;
        public UserOverview(User user)
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
            TicketOverview ticketOverview = new TicketOverview(currentUser);
            ticketOverview.Show();
            this.Hide();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            UserAdd userAdd = new UserAdd(currentUser);
            userAdd.Show();
            this.Hide();
        }

        public void PopulateDataGridView()
        {
            UserCRUD userCRUD = new UserCRUD();
            List<User> users = new List<User>();

            users = userCRUD.ReadUsers();

            table = new DataTable();


            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("# Tickets", typeof(int));

            foreach (User user in users)
            {
                table.Rows.Add(user._id, user.email, user.firstName, user.lastName, user.ticketCount);
            }

            dgv_UserOverview.DataSource = table;
            dgv_UserOverview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_UserOverview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_UserOverview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_UserOverview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_UserOverview.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void tb_filter_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = "Email LIKE '%" + tb_filter.Text + "%'";
            dgv_UserOverview.DataSource = dv;
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
