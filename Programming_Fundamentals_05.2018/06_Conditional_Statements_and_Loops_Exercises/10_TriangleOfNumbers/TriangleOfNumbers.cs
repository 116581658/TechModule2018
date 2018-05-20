using System;

namespace _10_TriangleOfNumbers
{
    class TriangleOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (1 <= n && n <= 20)
            {

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine();
                }

            }

        }
    }
}
