namespace Mo_Phong_Giai_Thuat_Sap_Xep
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PsswrdLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ForgotPssLink = new System.Windows.Forms.LinkLabel();
            this.SignUpLink = new System.Windows.Forms.LinkLabel();
            this.ShowpassCheck = new System.Windows.Forms.CheckBox();
            this.RmmbCheck = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(175, 83);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(199, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(175, 128);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(199, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.Location = new System.Drawing.Point(64, 83);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(101, 25);
            this.UsernameLbl.TabIndex = 3;
            this.UsernameLbl.Text = "Username";
            // 
            // PsswrdLbl
            // 
            this.PsswrdLbl.AutoSize = true;
            this.PsswrdLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PsswrdLbl.Location = new System.Drawing.Point(64, 128);
            this.PsswrdLbl.Name = "PsswrdLbl";
            this.PsswrdLbl.Size = new System.Drawing.Size(97, 25);
            this.PsswrdLbl.TabIndex = 4;
            this.PsswrdLbl.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(195, 222);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(115, 41);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ForgotPssLink);
            this.panel1.Controls.Add(this.SignUpLink);
            this.panel1.Controls.Add(this.ShowpassCheck);
            this.panel1.Controls.Add(this.RmmbCheck);
            this.panel1.Controls.Add(this.LoginBtn);
            this.panel1.Controls.Add(this.PsswrdLbl);
            this.panel1.Controls.Add(this.UsernameLbl);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Location = new System.Drawing.Point(155, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 340);
            this.panel1.TabIndex = 6;
            // 
            // ForgotPssLink
            // 
            this.ForgotPssLink.AutoSize = true;
            this.ForgotPssLink.Location = new System.Drawing.Point(279, 186);
            this.ForgotPssLink.Name = "ForgotPssLink";
            this.ForgotPssLink.Size = new System.Drawing.Size(103, 16);
            this.ForgotPssLink.TabIndex = 10;
            this.ForgotPssLink.TabStop = true;
            this.ForgotPssLink.Text = "Quên mật khẩu?";
            // 
            // SignUpLink
            // 
            this.SignUpLink.AutoSize = true;
            this.SignUpLink.Location = new System.Drawing.Point(279, 160);
            this.SignUpLink.Name = "SignUpLink";
            this.SignUpLink.Size = new System.Drawing.Size(172, 16);
            this.SignUpLink.TabIndex = 9;
            this.SignUpLink.TabStop = true;
            this.SignUpLink.Text = "Chưa có tài khoản? Đăng ký";
            this.SignUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLink_LinkClicked);
            // 
            // ShowpassCheck
            // 
            this.ShowpassCheck.AutoSize = true;
            this.ShowpassCheck.Location = new System.Drawing.Point(110, 182);
            this.ShowpassCheck.Name = "ShowpassCheck";
            this.ShowpassCheck.Size = new System.Drawing.Size(125, 20);
            this.ShowpassCheck.TabIndex = 8;
            this.ShowpassCheck.Text = "Show Password";
            this.ShowpassCheck.UseVisualStyleBackColor = true;
            this.ShowpassCheck.CheckedChanged += new System.EventHandler(this.ShowpassCheck_CheckedChanged);
            // 
            // RmmbCheck
            // 
            this.RmmbCheck.AutoSize = true;
            this.RmmbCheck.Location = new System.Drawing.Point(110, 156);
            this.RmmbCheck.Name = "RmmbCheck";
            this.RmmbCheck.Size = new System.Drawing.Size(119, 20);
            this.RmmbCheck.TabIndex = 7;
            this.RmmbCheck.Text = "Remember me";
            this.RmmbCheck.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PsswrdLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel ForgotPssLink;
        private System.Windows.Forms.LinkLabel SignUpLink;
        private System.Windows.Forms.CheckBox ShowpassCheck;
        private System.Windows.Forms.CheckBox RmmbCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}