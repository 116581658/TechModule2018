using System;

namespace _02_Circle_Area_Precision12
{
    class Circle_Area_Precision12
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI *(radius*radius);

            Console.WriteLine($"{area:f12}");

        }
    }
}
