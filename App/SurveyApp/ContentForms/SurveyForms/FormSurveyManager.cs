using Controllers;
using InjectionModules;
using SurveyApp.RegisterForms;

namespace SurveyApp.ContentForms
{
    public partial class FormSurveyManager : MetroFramework.Forms.MetroForm
    {
        private readonly ISurveyBLL _surveyBLL;

        public FormSurveyManager()
        {
            InitializeComponent();

            _surveyBLL = new SurveyBLL(SurveyModule.ConfiguratingModule());
            dgvSurveys.DataSource = _surveyBLL.GetAll().Data;
        }

        private void btnRegisterSurvey_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormRegisterSurvey());

        private void btnBack_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormContentAnalyst());

        private void dgvSurveys_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e) => new FormViewSurvey().ShowDialog();
    }
}
