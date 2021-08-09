using Controllers;

namespace SurveyApp.ContentForms
{
    public partial class FormSettings : MetroFramework.Forms.MetroForm
    {
        public FormSettings()
        {
            InitializeComponent();

            txtEmail.Text = SettingUser.LoggedUser.Email;
            txtLogin.Text = SettingUser.LoggedUser.Login;
            txtPassword.Text = SettingUser.LoggedUser.Password;
        }

        private void btnCancel_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormLogin()); // ---> Change this to back to FormOwner
    }
}
