using Controllers;
using InjectionModules;
using System.Windows.Forms;

namespace SurveyApp.ContentForms
{
    public partial class FormSettings : MetroFramework.Forms.MetroForm
    {
        private readonly IUserBLL _userBLL;

        public FormSettings()
        {
            InitializeComponent();
            _userBLL = new UserBLL(UserModule.ConfiguratingModule());

            txtEmail.Text = UserSetting.LoggedUser.Email;
            txtLogin.Text = UserSetting.LoggedUser.Login;
            txtPassword.Text = _userBLL.DecryptPassword(UserSetting.LoggedUser.Password).Data;
        }

        private void btnCancel_Click(object sender, System.EventArgs e) => Close();

        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Confirm Update Settings?", "Update Settings", MessageBoxButtons.OKCancel).Equals(DialogResult.OK))
            {
                var user = UserSetting.LoggedUser;
                user.Email = txtEmail.Text;
                user.Login = txtLogin.Text;
                user.Password = _userBLL.EncryptPassword(txtPassword.Text).Data;
                var response = _userBLL.Update(user);
                MessageBox.Show(response.Message);
            }
        }

        private void cbShowHidePassword_CheckedChanged(object sender, System.EventArgs e) => Helper.ShowHidePassword(cbShowHidePassword, txtPassword);
    }
}
