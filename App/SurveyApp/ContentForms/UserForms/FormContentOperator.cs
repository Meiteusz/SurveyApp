using Controllers;
using InjectionModules;
using SurveyApp.ContentForms.OccurrenceForms;

namespace SurveyApp.ContentForms
{
    public partial class FormContentOperator : MetroFramework.Forms.MetroForm
    {
        private readonly IUserBLL _userBLL;

        public FormContentOperator()
        {
            InitializeComponent();

            _userBLL = new UserBLL(UserModule.ConfiguratingModule());
        }
        
        private void FormContentOperator_Load(object sender, System.EventArgs e)
        {
            lblName.Text = UserSetting.LoggedUser.Name;
            lblUserType.Text = _userBLL.GetNameOfUserType(UserSetting.LoggedUser.UserType);
        }

        private void btnOccurrenceManager_Click_1(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormOccurrenceManager());

        private void btnSettings_Click_1(object sender, System.EventArgs e)
        {
            Helper.SetOwnerForm(new FormContentOperator());
            new FormSettings().ShowDialog();
        }

        private void btnLogout_Click_1(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormLogin());
    }
}