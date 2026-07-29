namespace Practice.Task7
{
    public class RInteger
    {
        public static int Reverse(int number)
        {
            int result = 0;


            while (number != 0)
            {
                int digit = number % 10;


               
                if (result > int.MaxValue / 10 ||
                    result < int.MinValue / 10)
                {
                    return 0;
                }


                result = result * 10 + digit;


                number /= 10;
            }


            return result;
        }
    }
}