using System;

namespace _11_OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            {

                while (n % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                    n = int.Parse(Console.ReadLine());

                }

                if (n % 2 != 0)
                {
                    int absolute = Math.Abs(n);
                    Console.WriteLine($"The number is: {absolute}");
                }
            }


        }
    }
}
