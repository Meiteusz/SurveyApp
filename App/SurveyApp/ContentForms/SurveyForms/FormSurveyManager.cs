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
            Helper.LoadDataGrid(dgvSurveys, _surveyBLL.GetAll().Data);
            cmbStatus.DataSource = _surveyBLL.GetSurveyStatus();
        }

        private void btnRegisterSurvey_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormRegisterSurvey());

        private void btnBack_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormContentAnalyst());

        private void dgvSurveys_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            var survey = _surveyBLL.Create();
            survey.Id = (int)dgvSurveys.CurrentRow.Cells[0].Value; //improving...
            SurveySetting.SetActualSurvey(_surveyBLL.GetById(survey).Data);
            new FormViewSurvey().ShowDialog();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            Helper.LoadDataGrid(dgvSurveys, _surveyBLL.GetByFilters(cmbStatus.SelectedIndex, txtResponsible.Text, dtpDateFrom.Value, dtpDateTo.Value, txtAdress.Text).Data);
        }
    }
}
