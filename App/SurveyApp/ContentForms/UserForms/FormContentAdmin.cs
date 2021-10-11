using Controllers;
using InjectionModules;
using SurveyApp.ContentForms;
using SurveyApp.ContentForms.UserForms;
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
            lblName.Text = UserSetting.LoggedUser.Name;
            lblUserType.Text = _userBLL.GetNameOfUserType(UserSetting.LoggedUser.UserType);

            lblUsersCount.Text = _userBLL.GetUsersCount().Data.ToString();
        }

        private void btnLogout_Click_1(object sender, EventArgs e) => Helper.ChangeForm(this, new FormLogin());

        private void btnUserManager_Click(object sender, EventArgs e) => Helper.ChangeForm(this, new FormUserManager());

        private void btnSettings_Click(object sender, EventArgs e) => new FormSettings().ShowDialog();
    }
}
