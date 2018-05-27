using System;

namespace _06_TriplesOfLetters
{
    class TriplesOfLetters
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                char first = (char)('a' + (i - 1));
                for (int j = 1; j <= num; j++)
                {
                    char second = (char)('a' + (j - 1));
                    for (int k = 1; k <= num; k++)
                    {
                        char third = (char)('a' + (k - 1));
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
