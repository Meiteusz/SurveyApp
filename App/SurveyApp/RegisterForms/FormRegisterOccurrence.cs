using SurveyApp.ContentForms.OccurrenceForms;

namespace SurveyApp.RegisterForms
{
    public partial class FormRegisterOccurrence : MetroFramework.Forms.MetroForm
    {
        public FormRegisterOccurrence()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormOccurrenceManager());
    }
}
