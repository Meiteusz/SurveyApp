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
            txtLogin.Text = "teste";
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
            var response = _userBLL.LoginUser(_userBLL.Create(txtLogin.Text, txtPassword.Text));

            if (response.Success)
            {
                SettingUser.SetLoggedUser(response.GetData);
                byte userType = response.GetData.UserType;

                if (userType.Equals(0)) // 0 = Admin
                    Helper.ChangeForm(this, new FormContentAdmin());
                else if (userType.Equals(1))
                    Helper.ChangeForm(this, new FormContentAnalist());
                else
                    Helper.ChangeForm(this, new FormContentOperator());
            }
            MessageBox.Show(response.Messege);
        }
    }
}
