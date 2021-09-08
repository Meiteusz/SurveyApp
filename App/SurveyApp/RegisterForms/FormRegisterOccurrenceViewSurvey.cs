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

        private void dgvSurveys_CellMouseDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e) 
        {
            SurveySetting.SetActualSurvey(_surveyBLL.GetById((int)dgvSurveys.CurrentRow.Cells[0].Value).Data);
            new FormRegisterOccurrence().ShowDialog();
        }

        private void btnRegisterOccurrence_Click_1(object sender, System.EventArgs e) => new FormRegisterOccurrence().ShowDialog();

        private void btnSearch_Click_1(object sender, System.EventArgs e) =>
            Helper.LoadDataGrid(dgvSurveys, _surveyBLL.GetByFilters(cmbStatus.SelectedIndex, txtResponsible.Text, dtpDateFrom.Value, dtpDateTo.Value, txtAdress.Text).Data);

        private void btnBack_Click_1(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormOccurrenceManager());
    }
}
