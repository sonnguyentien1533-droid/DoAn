using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mo_Phong_Giai_Thuat_Sap_Xep
{
    public partial class Login : Form
    {


        static class DatabaseHelper
        {

           
        }


        public Login()
        {
            InitializeComponent();
        }




        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            string userFile = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "users.txt"
            );

            if (!File.Exists(userFile))
            {
                MessageBox.Show("Chưa có tài khoản nào!");
                return;
            }

            var lines = File.ReadAllLines(userFile);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length >= 2 &&
                    parts[0] == username &&
                    parts[1] == password)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
        }



        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();
            this.Show();
        }

        private void ShowpassCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowpassCheck.Checked)
                txtPassword.UseSystemPasswordChar = false; // hiện pass thật
            else
                txtPassword.UseSystemPasswordChar = true;  // hiển thị ***
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
