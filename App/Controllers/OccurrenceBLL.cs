using Controllers.Interfaces;
using Models;
using Models.Entities.Interfaces;
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

        public ResponseData<Occurrence> GetById(Occurrence occurrence)
        {
            return _occurrence.GetById(occurrence);
        }

        public ResponseData<List<Occurrence>> GetAll()
        {
            return _occurrence.GetAll();
        }

        public Response Delete(Occurrence occurrence)
        {
            return _occurrence.Delete(occurrence);
        }
    }
}
