using Models;
using Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Controllers
{
    public class SurveyBLL : ISurveyBLL
    {
        private readonly ISurvey _survey;

        public SurveyBLL(ISurvey survey)
        {
            _survey = survey;
        }

        public Survey Create() => new Survey();

        public Response Insert(Survey survey)
        {
            survey.AnalistId = SettingUser.LoggedUser.Id;
            return _survey.Insert(survey);
        }

        #region Image --> Image setted on this block
        public ResponseData<byte[]> SetLocalImage(string fileName)
        {
            ResponseData<byte[]> response = new ResponseData<byte[]>();

            try
            {
                Bitmap bitmap = new Bitmap(fileName);

                response.Success = true;
                response.Data = ConvertImageToByte(bitmap); 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        private byte[] ConvertImageToByte(Bitmap bitmap)
        {
            byte[] imageByte;

            using (var memoryStream = new MemoryStream())
            {
                bitmap.Save(memoryStream, ImageFormat.Jpeg);
                imageByte = memoryStream.ToArray();
            }

            return imageByte;
        }
        #endregion

        public ResponseData<List<Survey>> GetAll()
        {
            return _survey.GetAll();
        }
    }
}
