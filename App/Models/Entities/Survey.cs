using Microsoft.EntityFrameworkCore;
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
        public int Status { get; set; }
        public DateTime OpeningDate { get; set; }
        public byte[] Local { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public int AnalistId { get; set; }
        public User Analist { get; set; }
        #endregion

        public Response Insert(Survey p_survey)
        {
            Response response = new Response();
            try
            {
                using (var context = new SurveyAppContext())
                {
                    context.Add(p_survey);
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

        public Response Update(Survey p_survey)
        {
            Response response = new Response();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    context.Entry(p_survey).State = EntityState.Modified;
                    context.SaveChanges();

                    response.Success = true;
                    response.Message = "Survey updated succefully";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public Response Delete(Survey p_survey)
        {
            Response response = new Response();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    context.Surveys.Remove(p_survey);
                    context.SaveChanges();

                    response.Success = true;
                    response.Message = "Survey Deleted Succefully";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public ResponseData<IEnumerable<dynamic>> GetAll()
        {
            ResponseData<IEnumerable<dynamic>> response = new ResponseData<IEnumerable<dynamic>>();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    var surveysList = (from s in context.Set<Survey>()
                                       join u in context.Set<User>()
                                       on s.AnalistId equals u.Id
                                       select new
                                       {
                                           Id = s.Id,
                                           Status = s.Status,
                                           OpeningDate = s.OpeningDate,
                                           Description = s.Description,
                                           Adress = s.Adress,
                                           ResponsibleName = u.Name
                                       }).ToList();

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

        public ResponseData<Survey> GetById(int p_SurveyId)
        {
            ResponseData<Survey> response = new ResponseData<Survey>();

            try
            {
                using (var context = new SurveyAppContext())
                {


                    var survey = context.Surveys.FirstOrDefault(s => s.Id.Equals(p_SurveyId));

                    response.Success = true;
                    response.Data = survey;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public ResponseData<IEnumerable<dynamic>> GetByFilters(int p_status, string p_responsible, DateTime p_dateFrom, DateTime p_dateTo, string p_adress)
        {
            ResponseData<IEnumerable<dynamic>> response = new ResponseData<IEnumerable<dynamic>>();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    var surveysList = (from s in context.Set<Survey>()
                                       join u in context.Set<User>()
                                       on s.AnalistId equals u.Id
                                       select new
                                       {
                                           Id = s.Id,
                                           Status = s.Status,
                                           OpeningDate = s.OpeningDate,
                                           Description = s.Description,
                                           Adress = s.Adress,
                                           ResponsibleName = u.Name
                                       }).Where(s => s.Status.Equals(p_status) && s.OpeningDate >= p_dateFrom && s.OpeningDate <= p_dateTo && s.Adress.Contains(p_adress)
                                        ).Where(u => u.ResponsibleName.Contains(p_responsible)).ToList();

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

        public ResponseData<int> GetSurveysCount()
        {
            ResponseData<int> response = new ResponseData<int>();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    var countSurveys = context.Surveys.Count();

                    response.Data = countSurveys;
                    response.Success = true;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public ResponseData<int> GetSurveyCountByUser(int p_userId)
        {
            ResponseData<int> response = new ResponseData<int>();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    var countSurveys = context.Surveys.Where(s => s.AnalistId.Equals(p_userId)).Count();

                    response.Data = countSurveys;
                    response.Success = true;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
