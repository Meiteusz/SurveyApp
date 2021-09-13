using Microsoft.EntityFrameworkCore;
using Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Occurrence : IOccurrence
    {
        #region Properties
        public int Id { get; set; }
        public byte Type { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int SurveyId { get; set; }
        public Survey Survey { get; set; }
        #endregion

        public Response Insert(Occurrence p_Occurrence)
        {
            Response response = new Response();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    context.Occurrences.Add(p_Occurrence);
                    context.SaveChanges();

                    response.Success = true;
                    response.Message = "Occurrence registered succefully";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public Response Update(Occurrence p_Occurrence)
        {
            Response response = new Response();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    context.Entry(p_Occurrence).State = EntityState.Modified;
                    context.SaveChanges();

                    response.Success = true;
                    response.Message = "Occurrence updated succefully";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public Response Delete(Occurrence p_Occurrence)
        {
            Response response = new Response();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    context.Occurrences.Remove(p_Occurrence);
                    context.SaveChanges();

                    response.Success = true;
                    response.Message = "Occurrence deleted succefully";
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
                    var occurrencesList = (from o in context.Set<Occurrence>()
                                           join s in context.Set<Survey>()
                                           on o.SurveyId equals s.Id
                                           join u in context.Set<User>()
                                           on s.AnalistId equals u.Id
                                           select new
                                           {
                                               Id = o.Id,
                                               Date = o.Date,
                                               Type = o.Type,
                                               OccurrenceDescription = o.Description,
                                               Status = s.Status,
                                               SurveyDescription = s.Description,
                                               Adress = s.Adress,
                                               OpeningSurveyDate = s.OpeningDate,
                                               SurveyResponsible = u.Name
                                           }).ToList();

                    response.Success = true;
                    response.Data = occurrencesList;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public ResponseData<Occurrence> GetById(int p_Id)
        {
            ResponseData<Occurrence> response = new ResponseData<Occurrence>();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    var occurrence = context.Occurrences.FirstOrDefault(o => o.Id.Equals(p_Id));

                    response.Success = true;
                    response.Data = occurrence;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public ResponseData<IEnumerable<dynamic>> GetByFilters(byte type, DateTime dateFrom, DateTime dateTo, string description, string surveyResponsible)
        {
            ResponseData<IEnumerable<dynamic>> response = new ResponseData<IEnumerable<dynamic>>();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    var occurrencesList = (from o in context.Set<Occurrence>()
                                           join s in context.Set<Survey>()
                                           on o.SurveyId equals s.Id
                                           join u in context.Set<User>()
                                           on s.AnalistId equals u.Id
                                           select new
                                           {
                                               Id = o.Id,
                                               Date = o.Date,
                                               Type = o.Type,
                                               OccurrenceDescription = o.Description,
                                               Status = s.Status,
                                               SurveyDescription = s.Description,
                                               Adress = s.Adress,
                                               OpeningSurveyDate = s.OpeningDate,
                                               SurveyResponsible = u.Name
                                           }).Where(o => o.Type.Equals(type) && o.Date >= dateFrom && o.Date <= dateTo && o.OccurrenceDescription.Contains(description) && 
                                           o.SurveyResponsible.Contains(surveyResponsible)).ToList();

                    response.Data = occurrencesList;
                    response.Success = true;
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
