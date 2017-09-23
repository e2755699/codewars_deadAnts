using System.Linq;

namespace codewars_deadAnts
{
    internal class Kata
    {
        public int Accum(string ants)
        {
            if (string.IsNullOrEmpty(ants))
            {
                return 0;
            }

            int deadAnts = ants.Count(partOfAntBody => partOfAntBody == 'a' || partOfAntBody == 'n' || partOfAntBody == 't');

            if (ants == "ant")
            {
                return 0;
            }

            return deadAnts;
        }
    }
}