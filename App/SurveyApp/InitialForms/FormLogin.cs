using Controllers;
using InjectionModules;
using System;
using System.Windows.Forms;

namespace SurveyApp
{
    public partial class FormLogin : Form
    {
        private readonly IUserBLL _userBLL;

        public FormLogin()
        {
            InitializeComponent();

            _userBLL = new UserBLL(Module.ConfiguratingModule());
        }

        private void cbShowHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            Helper.ShowHidePassword(cbShowHidePassword, txtPassword);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var response = _userBLL.LoginUser(_userBLL.Create(txtLogin.Text, txtPassword.Text));

            if (response.Success)
            {
                if (_userBLL.UserIsAdmin(response.GetData))
                    Helper.ChangeForm(this, new FormContentAdmin());
                else
                    Helper.ChangeForm(this, new FormContentAnalist());
            }
            MessageBox.Show(response.Messege);
        }

        private void btnPassword_Click(object sender, EventArgs e) => new FormPassword().ShowDialog();

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //txtPassword.Text = FormPassword.Password;
        }
    }
}
