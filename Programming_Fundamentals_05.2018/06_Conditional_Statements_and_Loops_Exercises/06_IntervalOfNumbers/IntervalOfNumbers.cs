using System;

namespace _06_IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());


            int min = Math.Min(numA, numB);
            int max = Math.Max(numA, numB);


            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
