using SurveyApp.ContentForms;

namespace SurveyApp
{
    public partial class FormContentAnalyst : MetroFramework.Forms.MetroForm
    {
        public FormContentAnalyst()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormLogin());

        private void btnSettings_Click(object sender, System.EventArgs e) => new FormSettings().ShowDialog();

        private void btnSurveyManager_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormSurveyManager());
    }
}
