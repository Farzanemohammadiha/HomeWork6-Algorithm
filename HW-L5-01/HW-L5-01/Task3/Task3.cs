namespace Practice.Task3
{
    public class LISequence
    {
        public static int Find(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;


            int currentLength = 1;
            int maxLength = 1;


            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                }


                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }


            return maxLength;
        }
    }
}