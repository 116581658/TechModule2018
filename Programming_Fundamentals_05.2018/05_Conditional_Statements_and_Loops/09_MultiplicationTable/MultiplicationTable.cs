using System;

namespace _09_MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int number = 10;
            if (1 <= n && n <= 100)
            {
                for (int i = 1; i <= number; i++)
                {
                    int product = n * i;
                    Console.WriteLine($"{n} X {i} = {product}");
                }
            }

        }
    }
}
