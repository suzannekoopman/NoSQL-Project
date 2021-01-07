namespace Project_ITSM_4
{
    partial class DashboardEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnl_Navigation = new System.Windows.Forms.Panel();
            this.lbl_Nav_Header1 = new System.Windows.Forms.Label();
            this.lbl_Nav_Header2 = new System.Windows.Forms.Label();
            this.btn_Incident = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Past_Deadline = new System.Windows.Forms.Label();
            this.lbl_Unresolved2 = new System.Windows.Forms.Label();
            this.lbl_Unresolved1 = new System.Windows.Forms.Label();
            this.lbl_DeadlineCounter = new System.Windows.Forms.Label();
            this.lbl_UnresolvedCounter = new System.Windows.Forms.Label();
            this.btn_ShowList = new System.Windows.Forms.Button();
            this.ch_Deadline = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.ch_Unresolved = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnl_Navigation.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Deadline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Unresolved)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Navigation
            // 
            this.pnl_Navigation.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Navigation.Controls.Add(this.lbl_Nav_Header1);
            this.pnl_Navigation.Controls.Add(this.lbl_Nav_Header2);
            this.pnl_Navigation.Controls.Add(this.btn_Incident);
            this.pnl_Navigation.Controls.Add(this.btn_Dashboard);
            this.pnl_Navigation.Location = new System.Drawing.Point(576, 12);
            this.pnl_Navigation.Name = "pnl_Navigation";
            this.pnl_Navigation.Size = new System.Drawing.Size(768, 108);
            this.pnl_Navigation.TabIndex = 5;
            // 
            // lbl_Nav_Header1
            // 
            this.lbl_Nav_Header1.AutoSize = true;
            this.lbl_Nav_Header1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nav_Header1.Location = new System.Drawing.Point(640, 9);
            this.lbl_Nav_Header1.Name = "lbl_Nav_Header1";
            this.lbl_Nav_Header1.Size = new System.Drawing.Size(125, 33);
            this.lbl_Nav_Header1.TabIndex = 7;
            this.lbl_Nav_Header1.Text = "NoDesk";
            // 
            // lbl_Nav_Header2
            // 
            this.lbl_Nav_Header2.AutoSize = true;
            this.lbl_Nav_Header2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nav_Header2.Location = new System.Drawing.Point(539, 51);
            this.lbl_Nav_Header2.Name = "lbl_Nav_Header2";
            this.lbl_Nav_Header2.Size = new System.Drawing.Size(226, 18);
            this.lbl_Nav_Header2.TabIndex = 6;
            this.lbl_Nav_Header2.Text = "Licensed to: The Garden Group";
            // 
            // btn_Incident
            // 
            this.btn_Incident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Incident.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Incident.Location = new System.Drawing.Point(384, 72);
            this.btn_Incident.Name = "btn_Incident";
            this.btn_Incident.Size = new System.Drawing.Size(384, 36);
            this.btn_Incident.TabIndex = 1;
            this.btn_Incident.Text = "Incident Management";
            this.btn_Incident.UseVisualStyleBackColor = true;
            this.btn_Incident.Click += new System.EventHandler(this.btn_Incident_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 72);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(384, 36);
            this.btn_Dashboard.TabIndex = 0;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Dashboard.Controls.Add(this.label4);
            this.pnl_Dashboard.Controls.Add(this.lbl_Past_Deadline);
            this.pnl_Dashboard.Controls.Add(this.lbl_Unresolved2);
            this.pnl_Dashboard.Controls.Add(this.lbl_Unresolved1);
            this.pnl_Dashboard.Controls.Add(this.lbl_DeadlineCounter);
            this.pnl_Dashboard.Controls.Add(this.lbl_UnresolvedCounter);
            this.pnl_Dashboard.Controls.Add(this.btn_ShowList);
            this.pnl_Dashboard.Controls.Add(this.ch_Deadline);
            this.pnl_Dashboard.Controls.Add(this.label1);
            this.pnl_Dashboard.Controls.Add(this.ch_Unresolved);
            this.pnl_Dashboard.Location = new System.Drawing.Point(576, 126);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(768, 942);
            this.pnl_Dashboard.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(399, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "These tickets need immediate attention";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Past_Deadline
            // 
            this.lbl_Past_Deadline.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Past_Deadline.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_Past_Deadline.Location = new System.Drawing.Point(402, 87);
            this.lbl_Past_Deadline.Name = "lbl_Past_Deadline";
            this.lbl_Past_Deadline.Size = new System.Drawing.Size(348, 33);
            this.lbl_Past_Deadline.TabIndex = 14;
            this.lbl_Past_Deadline.Text = "Incidents past deadline";
            this.lbl_Past_Deadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Unresolved2
            // 
            this.lbl_Unresolved2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unresolved2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_Unresolved2.Location = new System.Drawing.Point(22, 120);
            this.lbl_Unresolved2.Name = "lbl_Unresolved2";
            this.lbl_Unresolved2.Size = new System.Drawing.Size(348, 33);
            this.lbl_Unresolved2.TabIndex = 13;
            this.lbl_Unresolved2.Text = "All tickets currently open";
            this.lbl_Unresolved2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Unresolved1
            // 
            this.lbl_Unresolved1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unresolved1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_Unresolved1.Location = new System.Drawing.Point(21, 87);
            this.lbl_Unresolved1.Name = "lbl_Unresolved1";
            this.lbl_Unresolved1.Size = new System.Drawing.Size(345, 33);
            this.lbl_Unresolved1.TabIndex = 12;
            this.lbl_Unresolved1.Text = "Unresolved incidents";
            this.lbl_Unresolved1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DeadlineCounter
            // 
            this.lbl_DeadlineCounter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeadlineCounter.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_DeadlineCounter.Location = new System.Drawing.Point(406, 507);
            this.lbl_DeadlineCounter.Name = "lbl_DeadlineCounter";
            this.lbl_DeadlineCounter.Size = new System.Drawing.Size(344, 33);
            this.lbl_DeadlineCounter.TabIndex = 11;
            this.lbl_DeadlineCounter.Text = "1";
            this.lbl_DeadlineCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_UnresolvedCounter
            // 
            this.lbl_UnresolvedCounter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UnresolvedCounter.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_UnresolvedCounter.Location = new System.Drawing.Point(25, 507);
            this.lbl_UnresolvedCounter.Name = "lbl_UnresolvedCounter";
            this.lbl_UnresolvedCounter.Size = new System.Drawing.Size(341, 33);
            this.lbl_UnresolvedCounter.TabIndex = 10;
            this.lbl_UnresolvedCounter.Text = "7/15";
            this.lbl_UnresolvedCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ShowList
            // 
            this.btn_ShowList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ShowList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ShowList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowList.ForeColor = System.Drawing.Color.White;
            this.btn_ShowList.Location = new System.Drawing.Point(600, 18);
            this.btn_ShowList.Name = "btn_ShowList";
            this.btn_ShowList.Size = new System.Drawing.Size(150, 33);
            this.btn_ShowList.TabIndex = 8;
            this.btn_ShowList.Text = "Show List";
            this.btn_ShowList.UseVisualStyleBackColor = false;
            this.btn_ShowList.Click += new System.EventHandler(this.btn_ShowList_Click);
            // 
            // ch_Deadline
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_Deadline.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_Deadline.Legends.Add(legend1);
            this.ch_Deadline.Location = new System.Drawing.Point(402, 156);
            this.ch_Deadline.Name = "ch_Deadline";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ch_Deadline.Series.Add(series1);
            this.ch_Deadline.Size = new System.Drawing.Size(348, 348);
            this.ch_Deadline.TabIndex = 9;
            this.ch_Deadline.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current Incidents";
            // 
            // ch_Unresolved
            // 
            chartArea2.Name = "ChartArea1";
            this.ch_Unresolved.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ch_Unresolved.Legends.Add(legend2);
            this.ch_Unresolved.Location = new System.Drawing.Point(25, 156);
            this.ch_Unresolved.Name = "ch_Unresolved";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ch_Unresolved.Series.Add(series2);
            this.ch_Unresolved.Size = new System.Drawing.Size(348, 348);
            this.ch_Unresolved.TabIndex = 0;
            this.ch_Unresolved.Text = "chart1";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogOut.Location = new System.Drawing.Point(1780, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(128, 50);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // DashboardEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.pnl_Navigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardEmployee";
            this.Text = "Dashboard Statistics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Navigation.ResumeLayout(false);
            this.pnl_Navigation.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Deadline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Unresolved)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Navigation;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Label lbl_Nav_Header1;
        private System.Windows.Forms.Label lbl_Nav_Header2;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Unresolved;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Deadline;
        private System.Windows.Forms.Button btn_ShowList;
        private System.Windows.Forms.Label lbl_DeadlineCounter;
        private System.Windows.Forms.Label lbl_UnresolvedCounter;
        private System.Windows.Forms.Label lbl_Unresolved1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Past_Deadline;
        private System.Windows.Forms.Label lbl_Unresolved2;
        private System.Windows.Forms.Button btn_Incident;
        private System.Windows.Forms.Button btnLogOut;
    }
}