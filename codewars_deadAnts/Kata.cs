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
                int head = 0;
                foreach (var postion in input)
                {
                    if (postion == 'a')
                    {
                        head++;
                    }
                }
                return head;
            }
            else
            {
                return 0;
            }
        }
    }
}