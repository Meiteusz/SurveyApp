using Controllers;
using InjectionModules;
using SurveyApp.ContentForms;
using System;
using System.Windows.Forms;

namespace SurveyApp
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        private readonly IUserBLL _userBLL;

        public FormLogin()
        {
            InitializeComponent();
            _userBLL = new UserBLL(UserModule.ConfiguratingModule());
            txtLogin.Text = "apagar";
            txtPassword.Text = "123";
        }

        private void cbShowHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            Helper.ShowHidePassword(cbShowHidePassword, txtPassword);
        }
        private void btnPassword_Click(object sender, EventArgs e)
        {
            new FormPassword().ShowDialog();
            txtPassword.Text = FormPassword.Password;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var response = _userBLL.LoginUser(_userBLL.Create(txtLogin.Text, _userBLL.EncryptPassword(txtPassword.Text).Data));

            if (response.Success)
            {
                byte userType = response.Data.UserType;
                Helper.ChangeForm(this, OpenUserForm(userType));
            }
            MessageBox.Show(response.Message);
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private Form OpenUserForm(byte userType)
        {
            if (userType.Equals(0)) // 0 = Admin
                return new FormContentAdmin();
            else if (userType.Equals(1))
                return new FormContentAnalyst();
            else
                return new FormContentOperator();
        }
    }
}
