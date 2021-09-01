using Models;

namespace Controllers
{
    public abstract class OccurrenceSetting
    {
        public static Occurrence ActualOccurrence { get; private set; }

        public static void SetctualOccurrence(Occurrence occurrence)
        {
            ActualOccurrence = occurrence;
        }
    }
}
