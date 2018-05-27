using System;

namespace _09_RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int quotient = 0;
            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                quotient = i;
                int reminder = 0;
                while (quotient > 0)
                {
                    reminder = quotient % 10;
                    sum += reminder;
                    quotient = quotient / 10;
                }

                bool special = (sum == 5) || (sum == 7) || (sum == 11);
                if (special)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }

            }
        }
    }
}
