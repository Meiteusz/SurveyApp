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
        }

        private void FormSettings_Load(object sender, System.EventArgs e)
        {
            txtEmail.Text = UserSetting.LoggedUser.Email;
            txtLogin.Text = UserSetting.LoggedUser.Login;
            txtPassword.Text = _userBLL.DecryptPassword(UserSetting.LoggedUser.Password).Data;
        }

        private void btnConfirm_Click_1(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Confirm Update Settings?", "Update Settings", MessageBoxButtons.OKCancel).Equals(DialogResult.OK))
            {
                var user = UserSetting.LoggedUser;
                user.Email = txtEmail.Text;
                user.Login = txtLogin.Text;
                user.Password = txtPassword.Text;
                var response = _userBLL.Update(user);
                MessageBox.Show(response.Message);
            }
        }

        private void btnCancel_Click_1(object sender, System.EventArgs e) => Close();

        private void cbShowHidePassword_CheckedChanged(object sender, System.EventArgs e) => Helper.ShowHidePassword(cbShowHidePassword, txtPassword);

        private void btnPassword_Click(object sender, System.EventArgs e)
        {
            new FormPassword().ShowDialog();
            txtPassword.Text = FormPassword.Password;
        }
    }
}
