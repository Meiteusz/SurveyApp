using Controllers;
using Controllers.Interfaces;
using InjectionModules;
using SurveyApp.ContentForms.OccurrenceForms;

namespace SurveyApp.RegisterForms
{
    public partial class FormRegisterOccurrenceViewSurvey : MetroFramework.Forms.MetroForm
    {
        private readonly IOccurrenceBLL _occurrenceBLL;
        private readonly ISurveyBLL _surveyBLL;

        public FormRegisterOccurrenceViewSurvey()
        {
            InitializeComponent();

            _occurrenceBLL = new OccurrenceBLL(OccurrenceModule.ConfiguratingModule());
            _surveyBLL = new SurveyBLL(SurveyModule.ConfiguratingModule());
        }

        private void FormRegisterOccurrence_Load(object sender, System.EventArgs e) => Helper.LoadDataGrid(dgvSurveys, _surveyBLL.GetAll().Data);

        private void btnBack_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormOccurrenceManager());

        private void dgvSurveys_CellMouseDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e) 
        {
            var survey = _surveyBLL.Create();
            survey.Id = (int)dgvSurveys.CurrentRow.Cells[0].Value;
            SurveySetting.SetActualSurvey(_surveyBLL.GetById(survey).Data);
            new FormRegisterOccurrence().ShowDialog();
        }

        private void btnRegisterOccurrence_Click(object sender, System.EventArgs e) => new FormRegisterOccurrence().ShowDialog();

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            Helper.LoadDataGrid(dgvSurveys, _surveyBLL.GetByFilters(cmbStatus.SelectedIndex, txtResponsible.Text, dtpDateFrom.Value, dtpDateTo.Value, txtAdress.Text).Data);
        }
    }
}
