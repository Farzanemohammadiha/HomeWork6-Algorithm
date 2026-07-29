using System.Collections.Generic;

namespace Practice.Task4
{
    public class Jam
    {
        public static bool HasPair(int[] numbers, int target)
        {
            Dictionary<int, int> seenNumbers = new Dictionary<int, int>();


            foreach (int number in numbers)
            {
                int c = target - number;


                if (seenNumbers.ContainsKey(c))
                {
                    return true;
                }


                seenNumbers[number] = 1;
            }


            return false;
        }
    }
}