using Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Survey : ISurvey
    {
        #region Properties
        public int Id { get; set; }
        public byte Status { get; set; }
        public DateTime OpeningDate { get; set; }
        public byte[] Local { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public ICollection<Occurrence> OccurrenceList { get; set; }
        public int AnalistId { get; set; }
        public User Analist { get; set; }
        #endregion

        public Response Insert(Survey survey)
        {
            Response response = new Response();
            try
            {
                using (var context = new SurveyAppContext())
                {
                    context.Add(survey);
                    context.SaveChanges();

                    response.Success = true;
                    response.Message = "Survey registered succeffully";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public ResponseData<List<Survey>> GetAll()
        {
            ResponseData<List<Survey>> response = new ResponseData<List<Survey>>();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    var surveysList = context.Surveys.ToList();

                    response.Success = true;
                    response.Data = surveysList;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
