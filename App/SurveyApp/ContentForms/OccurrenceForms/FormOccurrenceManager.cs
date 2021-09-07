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
        }

        private void btnRegisterOccurrence_Click_1(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormRegisterOccurrenceViewSurvey());

        private void btnBack_Click_1(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormContentOperator());

        private void dgvOccurrence_CellMouseDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            var occurrence = _occurrenceBLL.Create();
            occurrence.Id = (int)dgvOccurrence.CurrentRow.Cells[0].Value; //improving...
            OccurrenceSetting.SetctualOccurrence(_occurrenceBLL.GetById(occurrence).Data);
            new FormViewOccurrence().ShowDialog();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {

        }
    }
}
