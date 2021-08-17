using Controllers;
using InjectionModules;
using System.Drawing;
using System.IO;

namespace SurveyApp.ContentForms
{
    public partial class FormViewSurvey : MetroFramework.Forms.MetroForm
    {
        private readonly ISurveyBLL _surveyBLL;

        public FormViewSurvey()
        {
            InitializeComponent();
            _surveyBLL = new SurveyBLL(SurveyModule.ConfiguratingModule());
        }
        private void FormViewSurvey_Load(object sender, System.EventArgs e)
        {
            txtAdress.Text = SurveySetting.ActualSurvey.Adress;
            pbLocalImage.Image = Image.FromStream(new MemoryStream(SurveySetting.ActualSurvey.Local));
            dtpOpeningDate.Value = SurveySetting.ActualSurvey.OpeningDate;
            txtDescription.Text = SurveySetting.ActualSurvey.Description;
            txtStatus.Text = SurveySetting.ActualSurvey.Status.ToString();
        }

        private void btnCancel_Click(object sender, System.EventArgs e) => Close();

    }
}
