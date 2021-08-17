using Controllers;

namespace SurveyApp.ContentForms
{
    public partial class FormSettings : MetroFramework.Forms.MetroForm
    {
        public FormSettings()
        {
            InitializeComponent();

            txtEmail.Text = UserSetting.LoggedUser.Email;
            txtLogin.Text = UserSetting.LoggedUser.Login;
            txtPassword.Text = UserSetting.LoggedUser.Password;
        }

        private void btnCancel_Click(object sender, System.EventArgs e) => Close();
    }
}
