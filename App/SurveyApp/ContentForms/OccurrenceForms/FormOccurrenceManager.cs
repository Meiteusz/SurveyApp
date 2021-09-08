using Controllers;
using Controllers.Interfaces;
using InjectionModules;
using SurveyApp.RegisterForms;

namespace SurveyApp.ContentForms.OccurrenceForms
{
    public partial class FormOccurrenceManager : MetroFramework.Forms.MetroForm
    {
        private readonly IOccurrenceBLL _occurrenceBLL;

        public FormOccurrenceManager()
        {
            InitializeComponent();
            _occurrenceBLL = new OccurrenceBLL(OccurrenceModule.ConfiguratingModule());
        }

        private void FormOccurrenceManager_Load(object sender, System.EventArgs e)
        {
            Helper.LoadDataGrid(dgvOccurrence, _occurrenceBLL.GetAll().Data);
            ResizeColumns();
            cmbType.DataSource = _occurrenceBLL.GetOccurrenceTypes();
        }

        private void btnRegisterOccurrence_Click_1(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormRegisterOccurrenceViewSurvey());

        private void btnBack_Click_1(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormContentOperator());

        private void btnSearch_Click_1(object sender, System.EventArgs e) =>
            Helper.LoadDataGrid(dgvOccurrence, _occurrenceBLL.GetByFilters((byte)cmbType.SelectedIndex, dtpDateFrom.Value, dtpDateTo.Value, txtDescription.Text, txtSurveyResponsible.Text).Data);

        private void dgvOccurrence_CellMouseDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            OccurrenceSetting.SetctualOccurrence(_occurrenceBLL.GetById((int)dgvOccurrence.CurrentRow.Cells[0].Value).Data);
            new FormViewOccurrence().ShowDialog();
        }

        private void ResizeColumns()
        {
            for (int i = 0; i < dgvOccurrence.Columns.Count; i++)
                dgvOccurrence.Columns[i].Width = 110;
        }
    }
}
