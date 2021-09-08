using Controllers;
using Controllers.Interfaces;
using InjectionModules;
using System.Windows.Forms;

namespace SurveyApp.ContentForms.OccurrenceForms
{
    public partial class FormViewOccurrence : MetroFramework.Forms.MetroForm
    {
        private readonly IOccurrenceBLL _occurrenceBLL;
        private readonly ISurveyBLL _surveyBLL;
        private readonly IUserBLL _userBLL;

        public FormViewOccurrence()
        {
            InitializeComponent();
            _occurrenceBLL = new OccurrenceBLL(OccurrenceModule.ConfiguratingModule());
            _surveyBLL = new SurveyBLL(SurveyModule.ConfiguratingModule());
            _userBLL = new UserBLL(UserModule.ConfiguratingModule());
        }

        private void FormViewOccurrence_Load(object sender, System.EventArgs e)
        {
            cmbType.DataSource = _occurrenceBLL.GetOccurrenceTypes();
            dtpDate.Value = OccurrenceSetting.ActualOccurrence.Date;
            cmbType.SelectedIndex = OccurrenceSetting.ActualOccurrence.Type;
            txtDescription.Text = OccurrenceSetting.ActualOccurrence.Description;
            txtSurveyResponsible.Text = _userBLL.GetById(_surveyBLL.GetById(OccurrenceSetting.ActualOccurrence.SurveyId).Data.AnalistId).Data.Name; //improving
            txtSurveyAdress.Text = _surveyBLL.GetById(OccurrenceSetting.ActualOccurrence.SurveyId).Data.Adress;
        }

        private void btnCancel_Click_1(object sender, System.EventArgs e) => Close();

        private void btnConfirm_Click(object sender, System.EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            dtpDate.Enabled = true;
            cmbType.Enabled = true;
            txtDescription.Enabled = true;
            txtSurveyResponsible.Enabled = true;
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
