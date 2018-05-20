using System;

namespace _07_CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int ingredientNameLen = ingredient.Length;


            if (1 <= ingredientNameLen && ingredientNameLen <= 50)
            {
                int ingredientCounter = 0;
                while ((!ingredient.Equals("Bake!")) && ingredientCounter < 20)
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");

                    ingredient = Console.ReadLine();
                    ingredientCounter++;
                }

                Console.WriteLine($"Preparing cake with {ingredientCounter} ingredients.");
            }


        }
    }
}
