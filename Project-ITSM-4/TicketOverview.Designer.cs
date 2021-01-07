using System;

namespace Project_ITSM_4
{
    partial class TicketOverview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_TicketOverview = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.dgv_TicketOverview = new System.Windows.Forms.DataGridView();
            this.btn_CreateIncident = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pnl_Navigation = new System.Windows.Forms.Panel();
            this.lbl_Header1 = new System.Windows.Forms.Label();
            this.lbl_Header2 = new System.Windows.Forms.Label();
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_Incident = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnl_TicketOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TicketOverview)).BeginInit();
            this.pnl_Navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TicketOverview
            // 
            this.pnl_TicketOverview.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_TicketOverview.Controls.Add(this.textBox1);
            this.pnl_TicketOverview.Controls.Add(this.lbl_FirstName);
            this.pnl_TicketOverview.Controls.Add(this.dgv_TicketOverview);
            this.pnl_TicketOverview.Controls.Add(this.btn_CreateIncident);
            this.pnl_TicketOverview.Controls.Add(this.lbl_Header);
            this.pnl_TicketOverview.Location = new System.Drawing.Point(576, 126);
            this.pnl_TicketOverview.Name = "pnl_TicketOverview";
            this.pnl_TicketOverview.Size = new System.Drawing.Size(768, 942);
            this.pnl_TicketOverview.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(126, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 25);
            this.textBox1.TabIndex = 59;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstName.Location = new System.Drawing.Point(15, 75);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(105, 18);
            this.lbl_FirstName.TabIndex = 58;
            this.lbl_FirstName.Text = "Filter by email";
            // 
            // dgv_TicketOverview
            // 
            this.dgv_TicketOverview.AllowUserToAddRows = false;
            this.dgv_TicketOverview.AllowUserToDeleteRows = false;
            this.dgv_TicketOverview.AllowUserToOrderColumns = true;
            this.dgv_TicketOverview.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TicketOverview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TicketOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TicketOverview.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TicketOverview.Location = new System.Drawing.Point(18, 122);
            this.dgv_TicketOverview.Name = "dgv_TicketOverview";
            this.dgv_TicketOverview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TicketOverview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TicketOverview.RowHeadersVisible = false;
            this.dgv_TicketOverview.Size = new System.Drawing.Size(732, 805);
            this.dgv_TicketOverview.TabIndex = 57;
            // 
            // btn_CreateIncident
            // 
            this.btn_CreateIncident.AutoSize = true;
            this.btn_CreateIncident.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_CreateIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateIncident.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateIncident.ForeColor = System.Drawing.Color.White;
            this.btn_CreateIncident.Location = new System.Drawing.Point(630, 66);
            this.btn_CreateIncident.Name = "btn_CreateIncident";
            this.btn_CreateIncident.Size = new System.Drawing.Size(120, 36);
            this.btn_CreateIncident.TabIndex = 56;
            this.btn_CreateIncident.Text = "Create Incident";
            this.btn_CreateIncident.UseVisualStyleBackColor = false;
            this.btn_CreateIncident.Click += new System.EventHandler(this.btn_CreateIncident_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(12, 18);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(246, 33);
            this.lbl_Header.TabIndex = 10;
            this.lbl_Header.Text = "Overview tickets";
            // 
            // pnl_Navigation
            // 
            this.pnl_Navigation.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Navigation.Controls.Add(this.lbl_Header1);
            this.pnl_Navigation.Controls.Add(this.lbl_Header2);
            this.pnl_Navigation.Controls.Add(this.btn_User);
            this.pnl_Navigation.Controls.Add(this.btn_Incident);
            this.pnl_Navigation.Controls.Add(this.btn_Dashboard);
            this.pnl_Navigation.Location = new System.Drawing.Point(576, 12);
            this.pnl_Navigation.Name = "pnl_Navigation";
            this.pnl_Navigation.Size = new System.Drawing.Size(768, 108);
            this.pnl_Navigation.TabIndex = 9;
            // 
            // lbl_Header1
            // 
            this.lbl_Header1.AutoSize = true;
            this.lbl_Header1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header1.Location = new System.Drawing.Point(640, 9);
            this.lbl_Header1.Name = "lbl_Header1";
            this.lbl_Header1.Size = new System.Drawing.Size(125, 33);
            this.lbl_Header1.TabIndex = 7;
            this.lbl_Header1.Text = "NoDesk";
            // 
            // lbl_Header2
            // 
            this.lbl_Header2.AutoSize = true;
            this.lbl_Header2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header2.Location = new System.Drawing.Point(539, 51);
            this.lbl_Header2.Name = "lbl_Header2";
            this.lbl_Header2.Size = new System.Drawing.Size(226, 18);
            this.lbl_Header2.TabIndex = 6;
            this.lbl_Header2.Text = "Licensed to: The Garden Group";
            // 
            // btn_User
            // 
            this.btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_User.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_User.Location = new System.Drawing.Point(512, 72);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(256, 36);
            this.btn_User.TabIndex = 2;
            this.btn_User.Text = "User Management";
            this.btn_User.UseVisualStyleBackColor = true;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // btn_Incident
            // 
            this.btn_Incident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Incident.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Incident.Location = new System.Drawing.Point(256, 72);
            this.btn_Incident.Name = "btn_Incident";
            this.btn_Incident.Size = new System.Drawing.Size(256, 36);
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
            this.btn_Dashboard.Size = new System.Drawing.Size(256, 36);
            this.btn_Dashboard.TabIndex = 0;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBack.Location = new System.Drawing.Point(1350, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 50);
            this.btnBack.TabIndex = 60;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnLogOut.TabIndex = 61;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // TicketOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnl_TicketOverview);
            this.Controls.Add(this.pnl_Navigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketOverview";
            this.Text = "Ticket Overview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TicketOverview_Load);
            this.pnl_TicketOverview.ResumeLayout(false);
            this.pnl_TicketOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TicketOverview)).EndInit();
            this.pnl_Navigation.ResumeLayout(false);
            this.pnl_Navigation.PerformLayout();
            this.ResumeLayout(false);

        }

        private void TicketOverview_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        #endregion
        private System.Windows.Forms.Panel pnl_TicketOverview;
        private System.Windows.Forms.Panel pnl_Navigation;
        private System.Windows.Forms.Label lbl_Header1;
        private System.Windows.Forms.Label lbl_Header2;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Incident;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_CreateIncident;
        private System.Windows.Forms.DataGridView dgv_TicketOverview;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
    }
}