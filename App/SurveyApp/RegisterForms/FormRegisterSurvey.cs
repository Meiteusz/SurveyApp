using Controllers;
using InjectionModules;
using SurveyApp.ContentForms;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SurveyApp.RegisterForms
{
    public partial class FormRegisterSurvey : MetroFramework.Forms.MetroForm
    {
        private readonly ISurveyBLL _surveyBLL;

        public FormRegisterSurvey()
        {
            InitializeComponent();

            _surveyBLL = new SurveyBLL(SurveyModule.ConfiguratingModule());
        }

        private void btnRegister_Click_1(object sender, System.EventArgs e)
        {
            var survey = _surveyBLL.Create();
            survey.OpeningDate = dtpOpeningDate.Value;
            survey.Local = _surveyBLL.SetLocalImage(ofdLocalImage.FileName).Data;
            survey.Description = txtDescription.Text;
            survey.Adress = txtAdress.Text;

            var response = _surveyBLL.Insert(survey);

            MessageBox.Show(response.Message);
        }

        private void btnBack_Click_1(object sender, System.EventArgs e) => Helper.ChangeForm(this, new FormSurveyManager());

        private void btnLocalImage_Click(object sender, System.EventArgs e)
        {
            ofdLocalImage.Filter = "JPEG Files(*.jpg)|*.jpg";
            ofdLocalImage.ShowDialog();
            pbLocalImage.Image = Image.FromStream(new MemoryStream(_surveyBLL.SetLocalImage(ofdLocalImage.FileName).Data));
        }
    }
}
