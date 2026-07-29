

namespace Practice.Task10
{
    public class MaxOfThree
    {
        public static int Find(int[] numbers)
        {
            if (numbers == null || numbers.Length < 3)
                throw new ArgumentException("Array should have at least 3 elements");

            Array.Sort(numbers);

            int n = numbers.Length;

            int product1 =
                numbers[n - 1] *
                numbers[n - 2] *
                numbers[n - 3];

            int product2 =
                numbers[0] *
                numbers[1] *
                numbers[n - 1];

            return Math.Max(product1, product2);
        }
    }
}