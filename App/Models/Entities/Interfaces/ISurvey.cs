using System.Collections.Generic;

namespace Models.Entities.Interfaces
{
    public interface ISurvey
    {
        Response Insert(Survey p_survey);
        Response Update(Survey p_survey);
        Response Delete(Survey p_survey);
        ResponseData<List<Survey>> GetAll();
        ResponseData<Survey> GetById(Survey p_survey);
    }
}
