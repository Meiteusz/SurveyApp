using Controllers;
using InjectionModules;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

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

        private void btnLocalImage_Click(object sender, System.EventArgs e)
        {
            SetLocalImage();
        }
        private void pbLocalImage_Click(object sender, System.EventArgs e)
        {
            SetLocalImage();
        }

        private void SetLocalImage()
        {
            ofdLocalImage.Filter = "JPEG Files(*.jpg)|*.jpg";
            ofdLocalImage.ShowDialog();
            Bitmap bitmap = new Bitmap(ofdLocalImage.FileName);
            pbLocalImage.Image = bitmap;

            byte[] imagebyte;

            using (var memoryStream = new MemoryStream())
            {
                bitmap.Save(memoryStream, ImageFormat.Png);
                imagebyte = memoryStream.ToArray();
            }
        }
    }
}
