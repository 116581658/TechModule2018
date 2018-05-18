using System;

namespace _01_Passed
{
    class Passed
    {
        static void Main(string[] args)
        {
            float grade = float.Parse(Console.ReadLine());
            float converGrade = (float) Math.Round(grade, 2, MidpointRounding.AwayFromZero);

            if (converGrade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }

        }
    }
}
