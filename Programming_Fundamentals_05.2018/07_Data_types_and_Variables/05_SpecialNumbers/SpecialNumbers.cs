using System;

namespace _05_SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                int reminder = 0;
                int division = i;
                do
                {
                    reminder = division % 10;
                    division = (division) / 10;
                    sum += reminder;
                } while (division != 0);

                bool special = sum == 5 || sum == 7 || sum == 11;
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
