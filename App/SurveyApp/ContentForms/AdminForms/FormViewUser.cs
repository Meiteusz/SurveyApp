using Controllers;
using InjectionModules;

namespace SurveyApp.ContentForms.AdminForms
{
    public partial class FormViewUser : MetroFramework.Forms.MetroForm
    {
        private readonly IUserBLL _userBLL;

        public FormViewUser()
        {
            InitializeComponent();

            _userBLL = new UserBLL(UserModule.ConfiguratingModule());
        }

        private void FormViewUser_Load(object sender, System.EventArgs e)
        {
            cmbType.DataSource = _userBLL.GetUserTypes();
            cmbType.SelectedIndex = UserSetting.ActualUser.UserType;
            txtName.Text = UserSetting.ActualUser.Name;
            txtCpf.Text = UserSetting.ActualUser.Cpf;
            txtLogin.Text = UserSetting.ActualUser.Login;
            txtEmail.Text = UserSetting.ActualUser.Email;
            txtPassword.Text = UserSetting.ActualUser.Password;
        }

        private void cbShowHidePassword_CheckedChanged(object sender, System.EventArgs e) => Helper.ShowHidePassword(cbShowHidePassword, txtPassword);

        private void btnCancel_Click(object sender, System.EventArgs e) => Close();
    }
}
