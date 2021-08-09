namespace SurveyApp.ContentForms
{
    public partial class FormContentOperator : MetroFramework.Forms.MetroForm
    {
        public FormContentOperator()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormLogin());

        private void btnSettings_Click(object sender, System.EventArgs e)
        {
            Helper.SetOwnerForm(new FormContentOperator());
            Helper.ChangeForm(this, new FormSettings());
        }
    }
}