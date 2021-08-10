using Models.Entities.Interfaces;

namespace Controllers
{
    public class SurveyBLL : ISurveyBLL
    {
        private readonly ISurvey _survey;

        public SurveyBLL(ISurvey survey)
        {
            _survey = survey;
        }
    }
}
