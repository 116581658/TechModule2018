using System;

namespace _02_RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());

            decimal rectangleArea = width * height;
            decimal formatedRectangleArea = Math.Round(rectangleArea, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{formatedRectangleArea:0.00}");

        }
    }
}
