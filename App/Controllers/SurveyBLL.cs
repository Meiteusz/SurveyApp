using Models;
using Models.Entities.Interfaces;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Resources;

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

        public Array GetSurveyStatus() => Enum.GetValues(typeof(SurveyStatus));

        public Response Insert(Survey survey)
        {
            Response response = survey.SurveyValidate(false);

            if (response.Success)
            {
                survey.AnalistId = UserSetting.LoggedUser.Id;
                return _survey.Insert(survey);
            }
            return response;
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

        public Response Update(Survey survey)
        {
            Response response = survey.SurveyValidate(true);

            if (response.Success)
                return _survey.Update(survey);
            return response;
        }

        public Response Delete(Survey survey)
        {
            return _survey.Delete(survey);
        }

        public ResponseData<IEnumerable<dynamic>> GetAll()
        {
            return _survey.GetAll();
        }

        public ResponseData<Survey> GetById(int p_SurveyId)
        {
            return _survey.GetById(p_SurveyId);
        }

        public ResponseData<IEnumerable<dynamic>> GetByFilters(int p_status, string p_responsible, DateTime p_dateFrom, DateTime p_dateTo, string p_adress)
        {
            return _survey.GetByFilters(p_status, p_responsible, p_dateFrom, p_dateTo, p_adress);
        }

    }
}
