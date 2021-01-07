namespace Project_ITSM_4
{
    partial class UserOverview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Navigation = new System.Windows.Forms.Panel();
            this.lbl_Header1 = new System.Windows.Forms.Label();
            this.lbl_Header2 = new System.Windows.Forms.Label();
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_Incident = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.pnl_UserOverview = new System.Windows.Forms.Panel();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.dgv_UserOverview = new System.Windows.Forms.DataGridView();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.lbl_UserManagement = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnl_Navigation.SuspendLayout();
            this.pnl_UserOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserOverview)).BeginInit();
            this.SuspendLayout();
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
            this.btn_User.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_Incident.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_Dashboard.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 72);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(256, 36);
            this.btn_Dashboard.TabIndex = 0;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // pnl_UserOverview
            // 
            this.pnl_UserOverview.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_UserOverview.Controls.Add(this.lbl_FirstName);
            this.pnl_UserOverview.Controls.Add(this.dgv_UserOverview);
            this.pnl_UserOverview.Controls.Add(this.btn_AddUser);
            this.pnl_UserOverview.Controls.Add(this.tb_filter);
            this.pnl_UserOverview.Controls.Add(this.lbl_UserManagement);
            this.pnl_UserOverview.Location = new System.Drawing.Point(576, 126);
            this.pnl_UserOverview.Name = "pnl_UserOverview";
            this.pnl_UserOverview.Size = new System.Drawing.Size(768, 942);
            this.pnl_UserOverview.TabIndex = 11;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstName.Location = new System.Drawing.Point(15, 75);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(105, 18);
            this.lbl_FirstName.TabIndex = 57;
            this.lbl_FirstName.Text = "Filter by email";
            // 
            // dgv_UserOverview
            // 
            this.dgv_UserOverview.AllowUserToAddRows = false;
            this.dgv_UserOverview.AllowUserToDeleteRows = false;
            this.dgv_UserOverview.AllowUserToOrderColumns = true;
            this.dgv_UserOverview.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UserOverview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_UserOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UserOverview.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_UserOverview.Location = new System.Drawing.Point(18, 122);
            this.dgv_UserOverview.Name = "dgv_UserOverview";
            this.dgv_UserOverview.ReadOnly = true;
            this.dgv_UserOverview.RowHeadersVisible = false;
            this.dgv_UserOverview.Size = new System.Drawing.Size(732, 805);
            this.dgv_UserOverview.TabIndex = 0;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.AutoSize = true;
            this.btn_AddUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUser.ForeColor = System.Drawing.Color.White;
            this.btn_AddUser.Location = new System.Drawing.Point(625, 66);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(125, 36);
            this.btn_AddUser.TabIndex = 56;
            this.btn_AddUser.Text = "+ Add New User";
            this.btn_AddUser.UseVisualStyleBackColor = false;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // tb_filter
            // 
            this.tb_filter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_filter.Location = new System.Drawing.Point(126, 72);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(256, 26);
            this.tb_filter.TabIndex = 17;
            this.tb_filter.TextChanged += new System.EventHandler(this.tb_filter_TextChanged);
            // 
            // lbl_UserManagement
            // 
            this.lbl_UserManagement.AutoSize = true;
            this.lbl_UserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserManagement.Location = new System.Drawing.Point(12, 18);
            this.lbl_UserManagement.Name = "lbl_UserManagement";
            this.lbl_UserManagement.Size = new System.Drawing.Size(269, 33);
            this.lbl_UserManagement.TabIndex = 10;
            this.lbl_UserManagement.Text = "User Management";
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
            this.btnBack.TabIndex = 58;
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
            this.btnLogOut.TabIndex = 59;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // UserOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnl_UserOverview);
            this.Controls.Add(this.pnl_Navigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserOverview";
            this.Text = "Manage Users";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Navigation.ResumeLayout(false);
            this.pnl_Navigation.PerformLayout();
            this.pnl_UserOverview.ResumeLayout(false);
            this.pnl_UserOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Navigation;
        private System.Windows.Forms.Label lbl_Header1;
        private System.Windows.Forms.Label lbl_Header2;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Incident;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Panel pnl_UserOverview;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.TextBox tb_filter;
        private System.Windows.Forms.Label lbl_UserManagement;
        private System.Windows.Forms.DataGridView dgv_UserOverview;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
    }
}