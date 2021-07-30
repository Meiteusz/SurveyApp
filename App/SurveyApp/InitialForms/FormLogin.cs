using System;
using System.Windows.Forms;

namespace SurveyApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void cbShowHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            Helper.ShowHidePassword(cbShowHidePassword, txtPassword);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            new FormPassword().ShowDialog();
        }
    }
}
