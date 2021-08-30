using Models;
using System;
using System.Collections.Generic;

namespace Controllers.Interfaces
{
    public interface IOccurrenceBLL
    {
        Occurrence Create();
        Array GetOccurrenceTypes();
        Response Insert(Occurrence p_Occurrence);
        Response Delete(Occurrence occurrence);
        ResponseData<List<Occurrence>> GetAll();
        ResponseData<Occurrence> GetById(Occurrence occurrence);
        ResponseData<IEnumerable<dynamic>> GetByFilters();
    }
}
