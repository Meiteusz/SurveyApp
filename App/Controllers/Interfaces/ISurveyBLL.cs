using Models;
using System.Collections.Generic;

namespace Controllers
{
    public interface ISurveyBLL
    {
        Survey Create();
        Response Insert(Survey survey);
        ResponseData<byte[]> SetLocalImage(string fileName);
        ResponseData<List<Survey>> GetAll();
        ResponseData<Survey> GetById(Survey survey);
    }
}