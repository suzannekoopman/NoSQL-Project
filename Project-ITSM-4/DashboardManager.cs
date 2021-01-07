using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Logic;
using Model;

namespace Project_ITSM_4
{
    public partial class DashboardManager : Form
    {
        int incidents;
        int resolved;
        int open;
        int pastDeadline;
        int beforeDeadline;
        User currentUser;
        public DashboardManager(User user)
        {
            InitializeComponent();

            TicketCRUD ticketCRUD = new TicketCRUD();
            List<Ticket> tickets = new List<Ticket>();
            tickets = ticketCRUD.GetAllTickets();

            currentUser = user;
            incidents = tickets.Count;

            open = 0;
            pastDeadline = 0;

            foreach (Ticket ticket in tickets)
            {
                if (ticket.status == TicketStatus.Open)
                {
                    open++;
                }

                if (ticket.date.AddDays(7) > DateTime.Now)
                {
                    pastDeadline++;
                }
            }

            resolved = incidents - open;
            beforeDeadline = open - pastDeadline;

            DrawChartUnresolved();
            DrawChartDeadline();

            string lblUnresolved = string.Format("{0} / {1}", resolved, incidents);
            lbl_UnresolvedCounter.Text = lblUnresolved;
            lbl_DeadlineCounter.Text = pastDeadline.ToString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {

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

        private void btn_ShowList_Click(object sender, EventArgs e)
        {
            TicketOverview ticketOverview = new TicketOverview(currentUser);
            ticketOverview.Show();
            this.Hide();
        }

        private void DrawChartUnresolved()
        {
            string seriesName = "Unresolved";
            ch_Unresolved.Series.Add(seriesName);
            ch_Unresolved.Series[seriesName].ChartType = SeriesChartType.Pie;
            ch_Unresolved.Series[seriesName]["PieLabelStyle"] = "Disabled";

            ch_Unresolved.Series[seriesName].Points.AddXY("Resolved", resolved);
            ch_Unresolved.Series[seriesName].Points.AddXY("Open", open);
        }

        private void DrawChartDeadline()
        {
            string seriesName = "pastDeadline";
            ch_Deadline.Series.Add(seriesName);
            ch_Deadline.Series[seriesName].ChartType = SeriesChartType.Pie;
            ch_Deadline.Series[seriesName]["PieLabelStyle"] = "Disabled";

            ch_Deadline.Series[seriesName].Points.AddXY("Past Deadline", pastDeadline);
            ch_Deadline.Series[seriesName].Points.AddXY("Before Deadline", beforeDeadline);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
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
            Login login = new Login();
            login.Show();
        }
    }
}
