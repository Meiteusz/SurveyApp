using Controllers;
using Controllers.Interfaces;
using InjectionModules;
using System.Windows.Forms;

namespace SurveyApp.RegisterForms
{
    public partial class FormRegisterOccurrence : MetroFramework.Forms.MetroForm
    {
        private readonly IOccurrenceBLL _occurrenceBLL;

        public FormRegisterOccurrence()
        {
            InitializeComponent();
            _occurrenceBLL = new OccurrenceBLL(OccurrenceModule.ConfiguratingModule());
            cmbType.DataSource = _occurrenceBLL.GetOccurrenceTypes();
        }

        private void FormRegisterOccurrence_Load(object sender, System.EventArgs e)
        {
            txtSurveyResponsible.Text = SurveySetting.ActualSurvey.AnalistId.ToString();
            txtSurveyAdress.Text = SurveySetting.ActualSurvey.Adress;
        }

        private void btnCancel_Click(object sender, System.EventArgs e) => Close();

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            var occurrence = _occurrenceBLL.Create();
            occurrence.Type = (byte)cmbType.SelectedIndex; //Improving
            occurrence.Date = dtpDate.Value;
            occurrence.Description = txtDescription.Text;
            occurrence.SurveyId = SurveySetting.ActualSurvey.Id; //Improving

            var response = _occurrenceBLL.Insert(occurrence);

            MessageBox.Show(response.Message);
        }
    }
}
