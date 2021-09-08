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
        ResponseData<IEnumerable<dynamic>> GetAll();
        ResponseData<Occurrence> GetById(int p_Id);
        ResponseData<IEnumerable<dynamic>> GetByFilters(byte type, DateTime dateFrom, DateTime dateTo, string description, string surveyResponsible);
    }
}
