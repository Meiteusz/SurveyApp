using SurveyApp.RegisterForms;
using System.Drawing;

namespace SurveyApp.ContentForms
{
    public partial class FormSurveyManager : MetroFramework.Forms.MetroForm
    {
        public FormSurveyManager()
        {
            InitializeComponent();
        }

        private void btnRegisterSurvey_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormRegisterSurvey());
    }
}
