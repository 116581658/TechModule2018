using System;

namespace _03_ExactSumOfRealNumbers
{
    class ExactSumOfRealNumbers
    {
        static void Main(string[] args)
        {
            int digs = int.Parse(Console.ReadLine());
            decimal sum = 0M;

            while (digs > 0) {
                decimal num = decimal.Parse(Console.ReadLine());
                sum += num;

                digs--;
            }

            Console.WriteLine(sum);

        }
    }
}
