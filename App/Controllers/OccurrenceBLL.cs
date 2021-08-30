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
            return _occurrence.Insert(p_Occurrence);
        }

        public Response Delete(Occurrence occurrence)
        {
            return _occurrence.Delete(occurrence);
        }

        public ResponseData<List<Occurrence>> GetAll()
        {
            return _occurrence.GetAll();
        }

        public ResponseData<Occurrence> GetById(Occurrence occurrence)
        {
            return _occurrence.GetById(occurrence);
        }

        public ResponseData<IEnumerable<dynamic>> GetByFilters()
        {
            return _occurrence.GetByFilters();
        }
    }
}
