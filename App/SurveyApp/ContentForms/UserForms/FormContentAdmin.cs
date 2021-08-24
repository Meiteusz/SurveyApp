using Controllers;
using InjectionModules;
using SurveyApp.RegisterForms;
using System;

namespace SurveyApp
{
    public partial class FormContentAdmin : MetroFramework.Forms.MetroForm
    {
        private readonly IUserBLL _userBLL;

        public FormContentAdmin()
        {
            InitializeComponent();
            _userBLL = new UserBLL(UserModule.ConfiguratingModule());
        }

        private void FormContentAdmin_Load(object sender, EventArgs e)
        {
            Helper.LoadDataGrid(dgvUsers, _userBLL.GetAll().Data);
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
