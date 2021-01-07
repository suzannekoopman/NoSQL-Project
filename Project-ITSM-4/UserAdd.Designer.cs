namespace Project_ITSM_4
{
    partial class UserAdd
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
            this.pnl_UserAdd = new System.Windows.Forms.Panel();
            this.lbl_Email_Taken = new System.Windows.Forms.Label();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.cb_password = new System.Windows.Forms.CheckBox();
            this.cb_Location = new System.Windows.Forms.ComboBox();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pnl_Navigation = new System.Windows.Forms.Panel();
            this.lbl_Header1 = new System.Windows.Forms.Label();
            this.lbl_Header2 = new System.Windows.Forms.Label();
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_Incident = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnl_UserAdd.SuspendLayout();
            this.pnl_Navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_UserAdd
            // 
            this.pnl_UserAdd.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_UserAdd.Controls.Add(this.lbl_Email_Taken);
            this.pnl_UserAdd.Controls.Add(this.btn_AddUser);
            this.pnl_UserAdd.Controls.Add(this.btn_Cancel);
            this.pnl_UserAdd.Controls.Add(this.tb_Email);
            this.pnl_UserAdd.Controls.Add(this.tb_Phone);
            this.pnl_UserAdd.Controls.Add(this.tb_FirstName);
            this.pnl_UserAdd.Controls.Add(this.cb_password);
            this.pnl_UserAdd.Controls.Add(this.cb_Location);
            this.pnl_UserAdd.Controls.Add(this.cb_Type);
            this.pnl_UserAdd.Controls.Add(this.lbl_Password);
            this.pnl_UserAdd.Controls.Add(this.lbl_Location);
            this.pnl_UserAdd.Controls.Add(this.lbl_Phone);
            this.pnl_UserAdd.Controls.Add(this.lbl_Email);
            this.pnl_UserAdd.Controls.Add(this.lbl_Type);
            this.pnl_UserAdd.Controls.Add(this.tb_LastName);
            this.pnl_UserAdd.Controls.Add(this.lbl_LastName);
            this.pnl_UserAdd.Controls.Add(this.lbl_FirstName);
            this.pnl_UserAdd.Controls.Add(this.lbl_Header);
            this.pnl_UserAdd.Location = new System.Drawing.Point(576, 126);
            this.pnl_UserAdd.Name = "pnl_UserAdd";
            this.pnl_UserAdd.Size = new System.Drawing.Size(768, 942);
            this.pnl_UserAdd.TabIndex = 0;
            // 
            // lbl_Email_Taken
            // 
            this.lbl_Email_Taken.AutoSize = true;
            this.lbl_Email_Taken.ForeColor = System.Drawing.Color.Red;
            this.lbl_Email_Taken.Location = new System.Drawing.Point(473, 197);
            this.lbl_Email_Taken.Name = "lbl_Email_Taken";
            this.lbl_Email_Taken.Size = new System.Drawing.Size(99, 13);
            this.lbl_Email_Taken.TabIndex = 13;
            this.lbl_Email_Taken.Text = "Email already taken";
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUser.ForeColor = System.Drawing.Color.White;
            this.btn_AddUser.Location = new System.Drawing.Point(352, 345);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(115, 32);
            this.btn_AddUser.TabIndex = 12;
            this.btn_AddUser.Text = "Add User";
            this.btn_AddUser.UseVisualStyleBackColor = false;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(211, 345);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(115, 32);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(211, 189);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(256, 26);
            this.tb_Email.TabIndex = 7;
            this.tb_Email.TextChanged += new System.EventHandler(this.tb_Email_TextChanged);
            // 
            // tb_Phone
            // 
            this.tb_Phone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone.Location = new System.Drawing.Point(211, 225);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(256, 26);
            this.tb_Phone.TabIndex = 8;
            this.tb_Phone.TextChanged += new System.EventHandler(this.tb_Phone_TextChanged);
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FirstName.Location = new System.Drawing.Point(211, 81);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(256, 26);
            this.tb_FirstName.TabIndex = 4;
            this.tb_FirstName.TextChanged += new System.EventHandler(this.tb_FirstName_TextChanged);
            // 
            // cb_password
            // 
            this.cb_password.AutoSize = true;
            this.cb_password.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_password.Location = new System.Drawing.Point(211, 303);
            this.cb_password.Name = "cb_password";
            this.cb_password.Size = new System.Drawing.Size(253, 18);
            this.cb_password.TabIndex = 10;
            this.cb_password.Text = "yes, a password e-mail will be sent to the user";
            this.cb_password.UseVisualStyleBackColor = true;
            // 
            // cb_Location
            // 
            this.cb_Location.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Location.FormattingEnabled = true;
            this.cb_Location.Location = new System.Drawing.Point(211, 261);
            this.cb_Location.Name = "cb_Location";
            this.cb_Location.Size = new System.Drawing.Size(256, 26);
            this.cb_Location.TabIndex = 9;
            // 
            // cb_Type
            // 
            this.cb_Type.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Location = new System.Drawing.Point(211, 153);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(256, 26);
            this.cb_Type.TabIndex = 6;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(16, 300);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(126, 18);
            this.lbl_Password.TabIndex = 0;
            this.lbl_Password.Text = "Send password?";
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Location.Location = new System.Drawing.Point(16, 264);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(119, 18);
            this.lbl_Location.TabIndex = 0;
            this.lbl_Location.Text = "Location/branch";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(16, 228);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(109, 18);
            this.lbl_Phone.TabIndex = 0;
            this.lbl_Phone.Text = "Phone number";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(16, 192);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(114, 18);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "E-mail address";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Type.Location = new System.Drawing.Point(16, 156);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(92, 18);
            this.lbl_Type.TabIndex = 0;
            this.lbl_Type.Text = "Type of user";
            // 
            // tb_LastName
            // 
            this.tb_LastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_LastName.Location = new System.Drawing.Point(211, 117);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(256, 26);
            this.tb_LastName.TabIndex = 5;
            this.tb_LastName.TextChanged += new System.EventHandler(this.tb_LastName_TextChanged);
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastName.Location = new System.Drawing.Point(16, 120);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(84, 18);
            this.lbl_LastName.TabIndex = 0;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstName.Location = new System.Drawing.Point(16, 84);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(82, 18);
            this.lbl_FirstName.TabIndex = 0;
            this.lbl_FirstName.Text = "First name";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(13, 18);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(243, 33);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Create new user";
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
            this.pnl_Navigation.TabIndex = 0;
            // 
            // lbl_Header1
            // 
            this.lbl_Header1.AutoSize = true;
            this.lbl_Header1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header1.Location = new System.Drawing.Point(640, 9);
            this.lbl_Header1.Name = "lbl_Header1";
            this.lbl_Header1.Size = new System.Drawing.Size(125, 33);
            this.lbl_Header1.TabIndex = 0;
            this.lbl_Header1.Text = "NoDesk";
            // 
            // lbl_Header2
            // 
            this.lbl_Header2.AutoSize = true;
            this.lbl_Header2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header2.Location = new System.Drawing.Point(539, 51);
            this.lbl_Header2.Name = "lbl_Header2";
            this.lbl_Header2.Size = new System.Drawing.Size(226, 18);
            this.lbl_Header2.TabIndex = 0;
            this.lbl_Header2.Text = "Licensed to: The Garden Group";
            // 
            // btn_User
            // 
            this.btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_User.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_User.Location = new System.Drawing.Point(512, 72);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(256, 36);
            this.btn_User.TabIndex = 0;
            this.btn_User.TabStop = false;
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
            this.btn_Incident.TabIndex = 0;
            this.btn_Incident.TabStop = false;
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
            this.btn_Dashboard.TabStop = false;
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
            this.btnBack.TabIndex = 14;
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
            this.btnLogOut.TabIndex = 58;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnl_UserAdd);
            this.Controls.Add(this.pnl_Navigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserAdd";
            this.Text = "Add User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserAdd_Load);
            this.pnl_UserAdd.ResumeLayout(false);
            this.pnl_UserAdd.PerformLayout();
            this.pnl_Navigation.ResumeLayout(false);
            this.pnl_Navigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_UserAdd;
        private System.Windows.Forms.Panel pnl_Navigation;
        private System.Windows.Forms.Label lbl_Header1;
        private System.Windows.Forms.Label lbl_Header2;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Incident;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.ComboBox cb_Location;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.CheckBox cb_password;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Email_Taken;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
    }
}