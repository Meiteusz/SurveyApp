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

        public ResponseData<Occurrence> GetById(Occurrence p_Occurrence)
        {
            ResponseData<Occurrence> response = new ResponseData<Occurrence>();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    var occurrence = context.Occurrences.FirstOrDefault(o => o.Id.Equals(p_Occurrence.Id));

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

        public ResponseData<List<Occurrence>> GetAll()
        {
            ResponseData<List<Occurrence>> response = new ResponseData<List<Occurrence>>();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    var occurrencesList = context.Occurrences.ToList();

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
    }
}
