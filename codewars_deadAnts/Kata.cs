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
            string newbody = string.Empty;
            foreach (var body in ants)
            {
                if (body == 'a' || body == 'n' || body == 't')
                {
                    newbody += body;
                }
            }
            
            ants = ants.Replace("ant", " ").Replace(" ","");
            int deadAnts = 0;
            ants = ants.Replace("an", " ");
            deadAnts += ants.Split(' ').Length - 1;
            ants = ants.Replace(" ", "").Replace("nt", " ");
            deadAnts += ants.Split(' ').Length - 1;
            ants = ants.Replace(" ", "").Replace("at", " ");
            deadAnts += ants.Split(' ').Length - 1;
            deadAnts += ants.Length;
            return deadAnts;
        }
    }
}