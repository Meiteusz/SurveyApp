using System;
using System.Collections.Generic;

namespace Models.Entities.Interfaces
{
    public interface ISurvey
    {
        Response Insert(Survey p_survey);
        Response Update(Survey p_survey);
        Response Delete(Survey p_survey);
        ResponseData<IEnumerable<dynamic>> GetAll();
        ResponseData<Survey> GetById(int p_SurveyId);
        ResponseData<IEnumerable<dynamic>> GetByFilters(int p_status, string p_responsible, DateTime p_dateFrom, DateTime p_dateTo, string p_adress);
        ResponseData<int> GetSurveysCount();
        ResponseData<int> GetSurveyCountByUser(int p_userId);
    }
}
