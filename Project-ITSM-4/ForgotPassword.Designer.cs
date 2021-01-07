namespace Project_ITSM_4
{
    partial class ForgotPassword
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
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.btn_Recover_Password = new System.Windows.Forms.Button();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.pnl_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Login
            // 
            this.pnl_Login.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Login.Controls.Add(this.lbl_Header);
            this.pnl_Login.Controls.Add(this.lbl_Description);
            this.pnl_Login.Controls.Add(this.btn_Recover_Password);
            this.pnl_Login.Controls.Add(this.txt_Username);
            this.pnl_Login.Controls.Add(this.lbl_Username);
            this.pnl_Login.Location = new System.Drawing.Point(384, 216);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(1152, 648);
            this.pnl_Login.TabIndex = 2;
            this.pnl_Login.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Login_Paint);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBack.Location = new System.Drawing.Point(1780, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 50);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(384, 165);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(384, 48);
            this.lbl_Header.TabIndex = 8;
            this.lbl_Header.Text = "Password Recovery";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Description
            // 
            this.lbl_Description.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(384, 214);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(384, 70);
            this.lbl_Description.TabIndex = 7;
            this.lbl_Description.Text = "Put your username down below and press on \"Recover Password\" to send an e-mail to" +
    " the respective email adress.";
            this.lbl_Description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Recover_Password
            // 
            this.btn_Recover_Password.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Recover_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recover_Password.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recover_Password.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Recover_Password.Location = new System.Drawing.Point(512, 465);
            this.btn_Recover_Password.Name = "btn_Recover_Password";
            this.btn_Recover_Password.Size = new System.Drawing.Size(128, 50);
            this.btn_Recover_Password.TabIndex = 6;
            this.btn_Recover_Password.Text = "Recover Password";
            this.btn_Recover_Password.UseVisualStyleBackColor = false;
            this.btn_Recover_Password.Click += new System.EventHandler(this.btn_Recover_Password_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(384, 333);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(384, 26);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(381, 312);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(80, 18);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnl_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Button btn_Recover_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btnBack;
    }
}