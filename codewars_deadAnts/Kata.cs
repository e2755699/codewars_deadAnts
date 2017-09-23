using System;
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

            bool IsDeadAnt(char partOfAntBody)
            {
                return partOfAntBody == 'a' || partOfAntBody == 'n' || partOfAntBody == 't';
            }
            int deadAnts = ants.Count(IsDeadAnt);

            return ants == "ant" ? 0 : deadAnts;
        }
    }
}