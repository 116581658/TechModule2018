using System;

namespace _08_SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int counter = 1;
                while (i <= n) {
                    if (counter % 2 == 1)
                    {
                        Console.WriteLine(counter);
                        i++;
                        sum += counter;
                    }
                    counter++;
                }
                
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
