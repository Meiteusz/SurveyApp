using Models;
using System.Collections.Generic;

namespace Controllers
{
    public interface ISurveyBLL
    {
        Survey Create();
        Response Insert(Survey survey);
        ResponseData<byte[]> SetLocalImage(string fileName);
        Response Update(Survey survey);
        Response Delete(Survey survey);
        ResponseData<List<Survey>> GetAll();
        ResponseData<Survey> GetById(Survey survey);
    }
}