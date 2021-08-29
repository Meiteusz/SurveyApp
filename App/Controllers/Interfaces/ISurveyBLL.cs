using Models;
using System;
using System.Collections.Generic;

namespace Controllers
{
    public interface ISurveyBLL
    {
        Survey Create();
        Array GetSurveyStatus();
        Response Insert(Survey survey);
        ResponseData<byte[]> SetLocalImage(string fileName);
        Response Update(Survey survey);
        Response Delete(Survey survey);
        ResponseData<IEnumerable<dynamic>> GetAll();
        ResponseData<Survey> GetById(Survey survey);
        ResponseData<IEnumerable<dynamic>> GetByFilters(int p_status, string p_responsible, DateTime p_dateFrom, DateTime p_dateTo, string p_adress);
    }
}