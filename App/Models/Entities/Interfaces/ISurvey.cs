using System.Collections.Generic;

namespace Models.Entities.Interfaces
{
    public interface ISurvey
    {
        Response Insert(Survey survey);
        ResponseData<List<Survey>> GetAll();
    }
}
