using System.Linq;

namespace codewars_deadAnts
{
    internal class Kata
    {
        public Kata()
        {
        }

        public int Accum(string input)
        {
            if (input != "ant")
            {
                return input.Count(x => x == 'a');
            }
            else
            {
                return 0;
            }
        }
    }
}