using Controllers;
using Controllers.Interfaces;
using InjectionModules;
using SurveyApp.RegisterForms;
using Syncfusion.XlsIO;
using System.IO;
using System.Windows.Forms;

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
            Helper.ResizeColumns(dgvOccurrence, 110);
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

        private void btnExport_Click(object sender, System.EventArgs e)
        {
            using (ExcelEngine excelEngine = new ExcelEngine()) // this code gonna be transfered to a control class
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2013;
                IWorkbook workbook = application.Workbooks.Create(1);
                IWorksheet worksheet = workbook.Worksheets[0];

                for (int i = 1; i < dgvOccurrence.Columns.Count + 1; i++)
                {
                    worksheet.Range[1, i].Text = dgvOccurrence.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvOccurrence.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvOccurrence.Columns.Count; j++)
                    {
                        worksheet.Range[i + 2, j + 1].Text = dgvOccurrence.Rows[i].Cells[j].Value.ToString();
                    }
                }
                sfdExportExcel.Filter = "XLSX Files(*.xlsx)|*.xlsx ";
                if (sfdExportExcel.ShowDialog().Equals(DialogResult.OK))
                {
                    FileStream fs = new FileStream(sfdExportExcel.FileName, FileMode.Create);
                    workbook.SaveAs(fs);
                    fs.Dispose();
                }
            }
            MessageBox.Show("Export done!");
        }
    }
}
