using System;

namespace _12_NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int value;
            decimal value2;
            long value3;

            if (int.TryParse(num, out value) || decimal.TryParse(num, out value2) || long.TryParse(num, out value3) ) {
                Console.WriteLine("It is a number.");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
