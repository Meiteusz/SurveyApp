using Controllers;
using Controllers.Interfaces;
using InjectionModules;
using System.Windows.Forms;

namespace SurveyApp.RegisterForms
{
    public partial class FormRegisterOccurrence : MetroFramework.Forms.MetroForm
    {
        private readonly IOccurrenceBLL _occurrenceBLL;
        private readonly ISurveyBLL _surveyBLL;
        private readonly IUserBLL _userBLL;


        public FormRegisterOccurrence()
        {
            InitializeComponent();

            _occurrenceBLL = new OccurrenceBLL(OccurrenceModule.ConfiguratingModule());
            _surveyBLL = new SurveyBLL(SurveyModule.ConfiguratingModule());
            _userBLL = new UserBLL(UserModule.ConfiguratingModule());
        }

        private void FormRegisterOccurrence_Load(object sender, System.EventArgs e)
        {
            cmbType.DataSource = _occurrenceBLL.GetOccurrenceTypes();
            txtSurveyResponsible.Text = _userBLL.GetById(_surveyBLL.GetById(SurveySetting.ActualSurvey.Id).Data.AnalistId).Data.Name; //improving
            txtSurveyAdress.Text = SurveySetting.ActualSurvey.Adress;
        }

        private void btnRegister_Click_1(object sender, System.EventArgs e)
        {
            var occurrence = _occurrenceBLL.Create();
            occurrence.Type = (byte)cmbType.SelectedIndex;
            occurrence.Date = dtpDate.Value;
            occurrence.Description = txtDescription.Text;
            occurrence.SurveyId = SurveySetting.ActualSurvey.Id;

            var response = _occurrenceBLL.Insert(occurrence);

            MessageBox.Show(response.Message);
        }

        private void btnCancel_Click_1(object sender, System.EventArgs e) => Close();
    }
}
