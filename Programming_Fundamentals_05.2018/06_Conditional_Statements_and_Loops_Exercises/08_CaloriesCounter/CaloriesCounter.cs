using System;

namespace _08_CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {

            int numIngred = int.Parse(Console.ReadLine());
            string ingredients = "";

            const int calCheese = 500;
            const int calTomatoSauce = 150;
            const int calSalami = 600;
            const int calPepper = 50;
            int calories = 0;


            while (numIngred > 0)
            {
                ingredients = Console.ReadLine();

                if (ingredients.ToLower().Equals("cheese"))
                {
                    calories += calCheese;
                }
                else if (ingredients.ToLower().Equals("tomato sauce"))
                {
                    calories += calTomatoSauce;
                }
                else if (ingredients.ToLower().Equals("salami"))
                {
                    calories += calSalami;
                }
                else if (ingredients.ToLower().Equals("pepper"))
                {
                    calories += calPepper;
                }

                numIngred--;

            }

            Console.WriteLine($"Total calories: {calories}");

        }
    }
}
