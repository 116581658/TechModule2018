using System;

namespace _03_RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {

            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hallName = "";
            double priceHall = 0;
            int discount = 0;
            int pricePackage = 0;
            double priceTotal = 0;
            double priceTotalWithDiscount = 0;
            double pricePerPerson = 0F;

            if (groupSize > 0 && groupSize <= 50)
            {
                hallName = "Small Hall";
                priceHall = 2500;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hallName = "Terrace";
                priceHall = 5000;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hallName = "Great Hall";
                priceHall = 7500;
            }
            else if (groupSize > 120)
            {
                hallName = "";
            }
            else
            {

            }


            if (package.Equals("Normal"))
            {
                discount = 5;
                pricePackage = 500;
            }
            else if (package.Equals("Gold"))
            {
                discount = 10;
                pricePackage = 750;
            }
            else if (package.Equals("Platinum"))
            {
                discount = 15;
                pricePackage = 1000;
            }
            else
            {

            }


            priceTotal = priceHall + pricePackage;
            priceTotalWithDiscount = priceTotal * ((100 - discount) / 100.0);
            pricePerPerson = Math.Round(priceTotalWithDiscount / groupSize, 2, MidpointRounding.AwayFromZero);


            if (hallName.Equals(""))
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:0.#0}$");
            }

        }
    }
}
