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
        Response Update(Occurrence p_Occurrence);
        Response Delete(Occurrence p_occurrence);
        ResponseData<IEnumerable<dynamic>> GetAll();
        ResponseData<Occurrence> GetById(int p_Id);
        ResponseData<IEnumerable<dynamic>> GetByFilters(byte p_type, DateTime p_dateFrom, DateTime p_dateTo, string p_description, string p_surveyResponsible);
    }
}
