namespace Project_ITSM_4
{
    partial class TicketAdd
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
            this.pnl_TicketAdd = new System.Windows.Forms.Panel();
            this.btn_AddTicket = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.Description_TxtBox = new System.Windows.Forms.TextBox();
            this.Priority_ComboBox = new System.Windows.Forms.ComboBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Priority = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pnl_Navigation = new System.Windows.Forms.Panel();
            this.lbl_Nav_Header1 = new System.Windows.Forms.Label();
            this.lbl_Nav_Header2 = new System.Windows.Forms.Label();
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_Incident = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnl_TicketAdd.SuspendLayout();
            this.pnl_Navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TicketAdd
            // 
            this.pnl_TicketAdd.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_TicketAdd.Controls.Add(this.btn_AddTicket);
            this.pnl_TicketAdd.Controls.Add(this.btn_Cancel);
            this.pnl_TicketAdd.Controls.Add(this.Description_TxtBox);
            this.pnl_TicketAdd.Controls.Add(this.Priority_ComboBox);
            this.pnl_TicketAdd.Controls.Add(this.lbl_Description);
            this.pnl_TicketAdd.Controls.Add(this.lbl_Priority);
            this.pnl_TicketAdd.Controls.Add(this.lbl_Header);
            this.pnl_TicketAdd.Location = new System.Drawing.Point(576, 126);
            this.pnl_TicketAdd.Name = "pnl_TicketAdd";
            this.pnl_TicketAdd.Size = new System.Drawing.Size(768, 942);
            this.pnl_TicketAdd.TabIndex = 12;
            // 
            // btn_AddTicket
            // 
            this.btn_AddTicket.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_AddTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddTicket.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTicket.ForeColor = System.Drawing.Color.White;
            this.btn_AddTicket.Location = new System.Drawing.Point(364, 327);
            this.btn_AddTicket.Name = "btn_AddTicket";
            this.btn_AddTicket.Size = new System.Drawing.Size(115, 32);
            this.btn_AddTicket.TabIndex = 55;
            this.btn_AddTicket.Text = "Add Ticket";
            this.btn_AddTicket.UseVisualStyleBackColor = false;
            this.btn_AddTicket.Click += new System.EventHandler(this.btn_AddTicket_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(223, 327);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(115, 32);
            this.btn_Cancel.TabIndex = 54;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Description_TxtBox
            // 
            this.Description_TxtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_TxtBox.Location = new System.Drawing.Point(223, 100);
            this.Description_TxtBox.Multiline = true;
            this.Description_TxtBox.Name = "Description_TxtBox";
            this.Description_TxtBox.Size = new System.Drawing.Size(256, 192);
            this.Description_TxtBox.TabIndex = 31;
            // 
            // Priority_ComboBox
            // 
            this.Priority_ComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priority_ComboBox.FormattingEnabled = true;
            this.Priority_ComboBox.Items.AddRange(new object[] {
            "Blocker",
            "Critical",
            "Major",
            "Minor"});
            this.Priority_ComboBox.Location = new System.Drawing.Point(223, 58);
            this.Priority_ComboBox.Name = "Priority_ComboBox";
            this.Priority_ComboBox.Size = new System.Drawing.Size(256, 26);
            this.Priority_ComboBox.TabIndex = 29;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(15, 103);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(88, 18);
            this.lbl_Description.TabIndex = 24;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_Priority
            // 
            this.lbl_Priority.AutoSize = true;
            this.lbl_Priority.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Priority.Location = new System.Drawing.Point(15, 61);
            this.lbl_Priority.Name = "lbl_Priority";
            this.lbl_Priority.Size = new System.Drawing.Size(57, 18);
            this.lbl_Priority.TabIndex = 20;
            this.lbl_Priority.Text = "Priority";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(12, 18);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(375, 33);
            this.lbl_Header.TabIndex = 9;
            this.lbl_Header.Text = "Create new incident ticket";
            // 
            // pnl_Navigation
            // 
            this.pnl_Navigation.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Navigation.Controls.Add(this.lbl_Nav_Header1);
            this.pnl_Navigation.Controls.Add(this.lbl_Nav_Header2);
            this.pnl_Navigation.Controls.Add(this.btn_User);
            this.pnl_Navigation.Controls.Add(this.btn_Incident);
            this.pnl_Navigation.Controls.Add(this.btn_Dashboard);
            this.pnl_Navigation.Location = new System.Drawing.Point(576, 12);
            this.pnl_Navigation.Name = "pnl_Navigation";
            this.pnl_Navigation.Size = new System.Drawing.Size(768, 108);
            this.pnl_Navigation.TabIndex = 11;
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
            this.btnBack.TabIndex = 56;
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
            this.btnLogOut.TabIndex = 57;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // TicketAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnl_TicketAdd);
            this.Controls.Add(this.pnl_Navigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketAdd";
            this.Text = "Add Incident Ticket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TicketAdd_Load);
            this.pnl_TicketAdd.ResumeLayout(false);
            this.pnl_TicketAdd.PerformLayout();
            this.pnl_Navigation.ResumeLayout(false);
            this.pnl_Navigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_TicketAdd;
        private System.Windows.Forms.Panel pnl_Navigation;
        private System.Windows.Forms.Label lbl_Nav_Header1;
        private System.Windows.Forms.Label lbl_Nav_Header2;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Incident;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TextBox Description_TxtBox;
        private System.Windows.Forms.ComboBox Priority_ComboBox;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Priority;
        private System.Windows.Forms.Button btn_AddTicket;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
    }
}