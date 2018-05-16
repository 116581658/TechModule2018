using System;

namespace _03_MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            decimal miles = decimal.Parse(Console.ReadLine());
            decimal kms = miles * (decimal)1.60934;


            decimal formatedKms = Math.Round(kms, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{formatedKms:0.00}");


        }
    }
}
