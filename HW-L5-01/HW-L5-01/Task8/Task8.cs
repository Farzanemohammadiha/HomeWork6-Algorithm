using System;

namespace Practice.Task8
{
    public class Triangle
    {
        public static bool CanbeTriangle(int[] numbers)
        {
            if (numbers == null || numbers.Length < 3)
                return false;


            Array.Sort(numbers);


            for (int i = 0; i < numbers.Length - 2; i++)
            {
                int a = numbers[i];
                int b = numbers[i + 1];
                int c = numbers[i + 2];


                if (a + b > c)
                {
                    return true;
                }
            }


            return false;
        }
    }
}