using System;
using System.Windows.Forms;

namespace SurveyApp
{
    public partial class FormPassword : Form
    {
        public static string Password { get; set; }
        public FormPassword()
        {
            InitializeComponent();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            Password += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Password += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Password += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Password += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Password += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Password += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Password += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Password += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Password += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Password += "9";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Password = "";
        }
    }
}
