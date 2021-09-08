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
        }

        private void FormSurveyManager_Load(object sender, System.EventArgs e)
        {
            Helper.LoadDataGrid(dgvSurveys, _surveyBLL.GetAll().Data);
            ResizeColumns();
            cmbStatus.DataSource = _surveyBLL.GetSurveyStatus();
        }

        private void btnRegisterSurvey_Click_1(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormRegisterSurvey());

        private void btnBack_Click(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormContentAnalyst());

        private void dgvSurveys_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            SurveySetting.SetActualSurvey(_surveyBLL.GetById((int)dgvSurveys.CurrentRow.Cells[0].Value).Data);
            new FormViewSurvey().ShowDialog();
        }

        private void btnSearch_Click_1(object sender, System.EventArgs e) =>
            Helper.LoadDataGrid(dgvSurveys, _surveyBLL.GetByFilters(cmbStatus.SelectedIndex, txtResponsible.Text, dtpDateFrom.Value, dtpDateTo.Value, txtAdress.Text).Data);

        private void btnBack_Click_1(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormContentAnalyst());

        private void ResizeColumns()
        {
            for (int i = 0; i < dgvSurveys.Columns.Count; i++)
                dgvSurveys.Columns[i].Width = 173;
        }
    }
}
