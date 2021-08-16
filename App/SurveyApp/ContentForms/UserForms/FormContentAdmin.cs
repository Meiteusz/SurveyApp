using SurveyApp.RegisterForms;
using System;
using System.Windows.Forms;

namespace SurveyApp
{
    public partial class FormContentAdmin : MetroFramework.Forms.MetroForm
    {
        public FormContentAdmin()
        {
            InitializeComponent();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            Helper.ChangeForm(this, new FormRegisterUser());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Helper.ChangeForm(this, new FormLogin());
        }
    }
}
