using System;
using System.Linq;

namespace codewars_deadAnts
{
    internal class Kata
    {
        public int Accum(string ants)
        {
            ants = ants?.Replace("ant", "") ?? "";
            return Math.Max(ants.Count(a => a == 't'), Math.Max(ants.Count(a => a == 'a'), ants.Count(a => a == 'n')));
        }
    }
}