using System;

namespace _12_Test_Numbers
{
    class Test_Numbers
    {
        static void Main(string[] args)
        {

            int numN = int.Parse(Console.ReadLine());
            int numM = int.Parse(Console.ReadLine());
            int maxSumBoundary = int.Parse(Console.ReadLine());
            int combCounter = 0;
            int totalSum = 0;
            bool isTotalSumless = true;

            for (int i = numN; i >= 1; i--)
            {
                for (int j = 1; j <= numM; j++)
                {
                    totalSum += 3 * (i * j);
                    combCounter++;

                    if (totalSum >= maxSumBoundary)
                    {
                        isTotalSumless = false;
                        break;
                    }
                }

                if (!isTotalSumless)
                {
                    break;
                }
            }


            if (isTotalSumless)
            {
                Console.WriteLine($"{combCounter} combinations");
                Console.WriteLine($"Sum: {totalSum}");
            }
            else
            {
                Console.WriteLine($"{combCounter} combinations");
                Console.WriteLine($"Sum: {totalSum} >= {maxSumBoundary}");
            }

        }
    }
}
