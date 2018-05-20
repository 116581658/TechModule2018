using System;

namespace _02_ChooseADrink2
{
    class ChooseADrink2
    {
        static void Main(string[] args)
        {

            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            float water = 0.7F;
            float coffee = 1.0F;
            float beer = 1.7F;
            float tea = 1.2F;
            double price;

            switch (profession)
            {
                case "Athlete":
                    price = water * quantity;
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = coffee * quantity;
                    break;
                case "SoftUni Student":
                    price = beer * quantity;
                    break;
                default:
                    price = tea * quantity;
                    break;
            }

            double totalPrice = Math.Round(price, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"The {profession} has to pay {totalPrice:0.#0}.");
        }
    }
}
