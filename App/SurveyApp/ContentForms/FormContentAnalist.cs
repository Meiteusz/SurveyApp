using SurveyApp.ContentForms;

namespace SurveyApp
{
    public partial class FormContentAnalist : MetroFramework.Forms.MetroForm
    {
        public FormContentAnalist()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormLogin());

        private void btnSettings_Click(object sender, System.EventArgs e) 
        {
            Helper.SetOwnerForm(new FormContentAnalist());
            Helper.ChangeForm(this, new FormSettings());
        }
    }
}
