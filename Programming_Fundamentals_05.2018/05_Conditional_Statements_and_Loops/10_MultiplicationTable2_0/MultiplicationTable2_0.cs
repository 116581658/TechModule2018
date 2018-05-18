using System;

namespace _10_MultiplicationTable2_0
{
    class MultiplicationTable2_0
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int fromNum = int.Parse(Console.ReadLine());
            int multiplier = 10;
            if (1 <= n && n <= 100)
            {
                if (fromNum <= 10)
                {
                    for (int i = fromNum; i <= multiplier; i++)
                    {
                        int product = n * i;
                        Console.WriteLine($"{n} X {i} = {product}");
                    }
                }
                else {
                    int product = n * fromNum;

                    Console.WriteLine($"{n} X {fromNum} = {product}");

                }

            }
        }
    }
}