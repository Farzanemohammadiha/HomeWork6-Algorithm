namespace Practice.Task1
{
    public class Fibonacci
    {
        public static long Calculate(int n)
        {
            if (n <= 1)
                return n;

            long former1 = 0;
            long former2 = 1;

            for (int i = 2; i <= n; i++)
            {
                long current = former1 + former2;

                former1 = former2;
                former2 = current;
            }

            return former2;
        }
    }
}