using System;

namespace _14_IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            string hex = Convert.ToString(num, 16);
            string bin = Convert.ToString(num, 2);

            Console.WriteLine($"{hex.ToUpper()}");
            Console.WriteLine($"{bin}");
        }
    }
}
