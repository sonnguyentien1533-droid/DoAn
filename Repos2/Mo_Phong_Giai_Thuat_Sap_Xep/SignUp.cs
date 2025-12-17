using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mo_Phong_Giai_Thuat_Sap_Xep
{
    public partial class SignUp : Form
    {

        private string generatedOTP = "";
        private DateTime otpExpiry;
        private System.Windows.Forms.Timer otpTimer;
        string userFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"users.txt"
);

        int countdown = 60;


        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string email = EmailBox.Text.Trim();
            string otpInput = OTPBox.Text.Trim();

            if (username == "" || password == "" || email == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (otpInput != generatedOTP)
            {
                MessageBox.Show("OTP không đúng!");
                return;
            }

            if (DateTime.Now > otpExpiry)
            {
                MessageBox.Show("OTP đã hết hạn, vui lòng gửi lại!");
                return;
            }


            string userFile = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "users.txt"
            );

            // Tạo file nếu chưa có
            if (!File.Exists(userFile))
                File.Create(userFile).Close();

            // Kiểm tra trùng username
            var lines = File.ReadAllLines(userFile);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts[0] == username)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                    return;
                }
            }

            // Ghi user mới
            string newUser = $"{username}|{password}|{email}";
            File.AppendAllText(userFile, newUser + Environment.NewLine);

            MessageBox.Show("Đăng ký thành công!");
            this.Close();
        }


        private void StartOTPTimer()
        {
            SendOTPBtn.Enabled = false; // tắt tương tác
            countdown = 60;
            otpTimer = new System.Windows.Forms.Timer();
            otpTimer.Interval = 1000; // 1 giây
            otpTimer.Tick += (s, e) =>
            {
                SendOTPBtn.Text = countdown + "s";
                countdown--;
                if (countdown < 0)
                {
                    otpTimer.Stop();
                    SendOTPBtn.Text = "Gửi OTP";
                    SendOTPBtn.Enabled = true; // bật lại nút
                }
            };
            otpTimer.Start();
        }

        private async void SendOTP(string toEmail)
        {
            string tempEmail = EmailBox.Text.Trim();

            if (string.IsNullOrEmpty(tempEmail))
            {
                MessageBox.Show("Vui lòng nhập email");
                return;
            }

            Random rnd = new Random();
            generatedOTP = rnd.Next(100000, 999999).ToString();
            otpExpiry = DateTime.Now.AddMinutes(5);

            // FAKE gửi mail
            MessageBox.Show(
                $" Mã xác nhận đăng ký\n\n" +
                $"Mã OTP của bạn là: {generatedOTP}\n",
                $"(Hết hạn sau 1 phút)",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            SendOTPBtn.Enabled = false;
            for (int i = 60; i >= 0; i--)
            {
                SendOTPBtn.Text = i + "s";
                await Task.Delay(1000); // không block UI
            }
            SendOTPBtn.Text = "Gửi OTP";
            SendOTPBtn.Enabled = true;

        }


        private void SendOTPBtn_Click(object sender, EventArgs e)
        {
            string email = EmailBox.Text.Trim();
            if (email == "")
            {
                MessageBox.Show("Vui lòng nhập email trước khi gửi OTP!");
                return;
            }
            SendOTP(email);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
