using System;
using System.Collections.Generic;

namespace Models.Entities.Interfaces
{
    public interface IOccurrence
    {
        Response Insert(Occurrence p_Occurrence);
        Response Update(Occurrence p_Occurrence);
        Response Delete(Occurrence p_Occurrence);
        ResponseData<IEnumerable<dynamic>> GetAll();
        ResponseData<Occurrence> GetById(int p_Id);
        ResponseData<IEnumerable<dynamic>> GetByFilters(byte type, DateTime dateFrom, DateTime dateTo, string description, string surveyResponsible);
    }
}
