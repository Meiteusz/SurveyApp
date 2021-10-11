using Controllers;
using Controllers.Interfaces;
using InjectionModules;
using SurveyApp.ContentForms.OccurrenceForms;

namespace SurveyApp.ContentForms
{
    public partial class FormContentOperator : MetroFramework.Forms.MetroForm
    {
        private readonly IUserBLL _userBLL;
        private readonly IOccurrenceBLL _occurrenceBLL;

        public FormContentOperator()
        {
            InitializeComponent();

            _userBLL = new UserBLL(UserModule.ConfiguratingModule());
            _occurrenceBLL = new OccurrenceBLL(OccurrenceModule.ConfiguratingModule());
        }
        
        private void FormContentOperator_Load(object sender, System.EventArgs e)
        {
            lblName.Text = UserSetting.LoggedUser.Name;
            lblUserType.Text = _userBLL.GetNameOfUserType(UserSetting.LoggedUser.UserType);

            lblOccurrencesCount.Text = _occurrenceBLL.GetOccurenceCount().Data.ToString();
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