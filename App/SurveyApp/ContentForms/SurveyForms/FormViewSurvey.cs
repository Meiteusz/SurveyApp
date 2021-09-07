using Controllers;
using InjectionModules;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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

        private void btnCancel_Click_1(object sender, System.EventArgs e) => Close();

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            txtAdress.Enabled = true;
            btnOpenImage.Enabled = true;
            txtDescription.Enabled = true;
            btnConfirm.Enabled = true;
        }

        private void btnConfirm_Click_1(object sender, System.EventArgs e)
        {
            var surveyUpdated = SurveySetting.ActualSurvey;
            surveyUpdated.Adress = txtAdress.Text;
            surveyUpdated.Local = _surveyBLL.SetLocalImage(ofdLocalImage.FileName).Data;
            surveyUpdated.Description = txtDescription.Text;

            var response = _surveyBLL.Update(surveyUpdated);
            MessageBox.Show(response.Message);
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Confirm Survey Delete?", "Survey Delete", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                var response = _surveyBLL.Delete(SurveySetting.ActualSurvey);
                MessageBox.Show(response.Message);
                Close();
            }
        }

        private void btnOpenImage_Click(object sender, System.EventArgs e)
        {
            ofdLocalImage.Filter = "JPEG Files(*.jpg)|*.jpg";
            ofdLocalImage.ShowDialog();
            pbLocalImage.Image = Image.FromStream(new MemoryStream(_surveyBLL.SetLocalImage(ofdLocalImage.FileName).Data));
        }
    }
}
