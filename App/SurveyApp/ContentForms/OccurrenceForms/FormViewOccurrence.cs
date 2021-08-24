using Controllers;
using Controllers.Interfaces;
using InjectionModules;
using System.Windows.Forms;

namespace SurveyApp.ContentForms.OccurrenceForms
{
    public partial class FormViewOccurrence : MetroFramework.Forms.MetroForm
    {
        private readonly IOccurrenceBLL _occurrenceBLL;

        public FormViewOccurrence()
        {
            InitializeComponent();
            _occurrenceBLL = new OccurrenceBLL(OccurrenceModule.ConfiguratingModule());
        }

        private void FormViewOccurrence_Load(object sender, System.EventArgs e)
        {
            dtpDate.Value = OccurrenceSetting.ActualOccurrence.Date;
            cmbType.Text = OccurrenceSetting.ActualOccurrence.Type.ToString();
            txtDescription.Text = OccurrenceSetting.ActualOccurrence.Description;
            txtSurvey.Text = OccurrenceSetting.ActualOccurrence.SurveyId.ToString();
        }

        private void btnCancel_Click(object sender, System.EventArgs e) => Close();

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            dtpDate.Enabled = true;
            cmbType.Enabled = true;
            txtDescription.Enabled = true;
            txtSurvey.Enabled = true;
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Confirm Occurrence Delete?", "Occurrence Delete", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                var response = _occurrenceBLL.Delete(OccurrenceSetting.ActualOccurrence);
                MessageBox.Show(response.Message);
                Close();
            }
        }
    }
}
