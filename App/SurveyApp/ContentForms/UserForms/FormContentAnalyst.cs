using Controllers;
using InjectionModules;
using SurveyApp.ContentForms;

namespace SurveyApp
{
    public partial class FormContentAnalyst : MetroFramework.Forms.MetroForm
    {
        private readonly IUserBLL _userBLL;
        private readonly ISurveyBLL _surveyBLL;

        public FormContentAnalyst()
        {
            InitializeComponent();

            _userBLL = new UserBLL(UserModule.ConfiguratingModule());
            _surveyBLL = new SurveyBLL(SurveyModule.ConfiguratingModule());
        }

        private void FormContentAnalyst_Load(object sender, System.EventArgs e)
        {
            lblName.Text = UserSetting.LoggedUser.Name;
            lblUserType.Text = _userBLL.GetNameOfUserType(UserSetting.LoggedUser.UserType);

            lblSurveysCount.Text = _surveyBLL.GetSurveysCount().Data.ToString();
            lblSurveysUserCount.Text = _surveyBLL.GetSurveyCountByUser(UserSetting.LoggedUser.Id).Data.ToString();
        }

        private void btnSurveyManager_Click_1(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormSurveyManager());

        private void btnSettings_Click_1(object sender, System.EventArgs e) => new FormSettings().ShowDialog();

        private void btnLogout_Click_1(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormLogin());
    }
}
