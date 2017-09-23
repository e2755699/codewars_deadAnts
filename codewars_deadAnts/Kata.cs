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
            ants = ants.Replace("ant", " ");
            int head = ants.Count(a => a == 'a');
            int body = ants.Count(a => a == 'n');
            int trail = ants.Count(a => a == 't');
            return Math.Max(trail, Math.Max(head, body));
        }
    }
}