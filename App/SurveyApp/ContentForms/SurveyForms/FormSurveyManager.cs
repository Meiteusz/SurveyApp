using Controllers;
using InjectionModules;
using SurveyApp.RegisterForms;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using System.IO;
using System.Data;

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
            Helper.ResizeColumns(dgvSurveys, 173);
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

        private void btnExport_Click(object sender, System.EventArgs e)
        {
            using (ExcelEngine excelEngine = new ExcelEngine()) // this code gonna be transfered to a control class
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2013;
                IWorkbook workbook = application.Workbooks.Create(1);
                IWorksheet worksheet = workbook.Worksheets[0];

                for (int i = 1; i < dgvSurveys.Columns.Count + 1; i++)
                {
                    worksheet.Range[1, i].Text = dgvSurveys.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvSurveys.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvSurveys.Columns.Count; j++)
                    {
                        worksheet.Range[i + 2, j + 1].Text = dgvSurveys.Rows[i].Cells[j].Value.ToString();
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
