namespace Practice.Task5
{
    public class NumberToWords
    {
        static string[] Ones =
        {
            "",
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Eleven",
            "Twelve",
            "Thirteen",
            "Fourteen",
            "Fifteen",
            "Sixteen",
            "Seventeen",
            "Eighteen",
            "Nineteen"
        };


        static string[] Tens =
        {
            "",
            "",
            "Twenty",
            "Thirty",
            "Forty",
            "Fifty",
            "Sixty",
            "Seventy",
            "Eighty",
            "Ninety"
        };


        public static string Convert(int number)
        {
            if (number == 0)
                return "Zero";


            if (number < 20)
                return Ones[number];


            if (number < 100)
            {
                return Tens[number / 10] +
                       (number % 10 != 0 ? " " + Ones[number % 10] : "");
            }


            if (number < 1000)
            {
                return Ones[number / 100] +
                       " Hundred " +
                       Convert(number % 100);
            }


            if (number < 10000)
            {
                return Ones[number / 1000] +
                       " Thousand " +
                       Convert(number % 1000);
            }


            return "not in the range";
        }
    }
}