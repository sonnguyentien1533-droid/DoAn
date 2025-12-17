using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mo_Phong_Giai_Thuat_Sap_Xep
{
    public partial class Form_ViewCode : Form
    {
        SoundPlayer clickPlayer;
        public Form_ViewCode(string code, Form1.Loai_Sap_Xep loai)
        {
            InitializeComponent();
            clickPlayer = new SoundPlayer(Properties.Resources.click);
            this.Text = $"View Code - {loai}";
            ViewCodeBox.Text = code;
        }

        void PlayClickSound()
        {
            clickPlayer.Stop();
            clickPlayer.Play();
        }
        private void ViewCodeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            PlayClickSound();
            this.Close();
            Owner?.Show();
        }

        private void Form_ViewCode_Load(object sender, EventArgs e)
        {
            BackBtn.BackColor = Color.LightBlue;
        }
    }
}
