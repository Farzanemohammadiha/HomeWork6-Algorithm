using System.Collections.Generic;

namespace Practice.Task6
{
    public class AvalinHarfMonhaserbefard
    {
        public static char? Find(string text)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();


            foreach (char c in text)
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                }
                else
                {
                    counts[c] = 1;
                }
            }


            foreach (char c in text)
            {
                if (counts[c] == 1)
                {
                    return c;
                }
            }


            return null;
        }
    }
}