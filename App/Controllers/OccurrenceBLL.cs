using Controllers.Interfaces;
using Models;
using Models.Entities.Interfaces;
using Models.Enums;
using System;
using System.Collections.Generic;

namespace Controllers
{
    public class OccurrenceBLL : IOccurrenceBLL
    {
        private readonly IOccurrence _occurrence;

        public OccurrenceBLL(IOccurrence occurrence)
        {
            _occurrence = occurrence;
        }

        public Occurrence Create() => new Occurrence();

        public Array GetOccurrenceTypes() => Enum.GetValues(typeof(OccurrenceType));

        public Response Insert(Occurrence p_Occurrence)
        {
            Response response = p_Occurrence.OccurrenceValidate(false);

            if (response.Success)
                return _occurrence.Insert(p_Occurrence);
            return response;
        }

        public Response Update(Occurrence p_Occurrence)
        {
            Response response = p_Occurrence.OccurrenceValidate(true);

            if (response.Success)
                return _occurrence.Update(p_Occurrence);
            return response;
        }

        public Response Delete(Occurrence occurrence)
        {
            return _occurrence.Delete(occurrence);
        }

        public ResponseData<IEnumerable<dynamic>> GetAll()
        {
            return _occurrence.GetAll();
        }

        public ResponseData<Occurrence> GetById(int p_Id)
        {
            return _occurrence.GetById(p_Id);
        }

        public ResponseData<IEnumerable<dynamic>> GetByFilters(byte type, DateTime dateFrom, DateTime dateTo, string description, string surveyResponsible)
        {
            return _occurrence.GetByFilters(type, dateFrom, dateTo, description, surveyResponsible);
        }

        public ResponseData<int> GetOccurenceCount()
        {
            return _occurrence.GetOccurenceCount();
        }
    }
}
