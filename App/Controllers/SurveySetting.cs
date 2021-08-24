using Models;

namespace Controllers
{
    public abstract class SurveySetting
    {
        public static Survey ActualSurvey { get; private set; }

        public static void SetActualSurvey(Survey survey)
        {
            ActualSurvey = survey;
        }
    }
}
