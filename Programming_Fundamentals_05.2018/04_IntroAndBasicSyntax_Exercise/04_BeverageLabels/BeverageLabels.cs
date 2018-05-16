using System;

namespace _04_BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            decimal sugarContent = decimal.Parse(Console.ReadLine());

            decimal energyContentPer1ml = energyContent / 100.0M;
            decimal sugarContentPer1ml = sugarContent / 100.0M;

            decimal kcal = volume * energyContentPer1ml;
            decimal grams = Math.Round(volume * sugarContentPer1ml, 2, MidpointRounding.AwayFromZero);

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kcal:#.##}kcal, {grams:#.##}g sugars");  
            /*
            * NOTE: #.## was needed to receive 100 points but I don't know the tests
            */
        }
    }
}
