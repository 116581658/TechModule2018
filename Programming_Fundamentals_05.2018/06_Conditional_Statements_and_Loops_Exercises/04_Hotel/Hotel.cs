using System;

namespace _04_Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double discountPercentsStudio = 0;
            double discountPercentsDouble = 0;
            double discountPercentsSuite = 0;
            int priceStudio = 0;
            int priceDouble = 0;
            int priceSuite = 0;
            int nightsStudio = nights;
            int nightsDouble = nights;
            int nightsSuite = nights;

            if (0 <= nights && nights <= 200)
            {

                if (month.Equals("May") ||         //31
                    month.Equals("October"))       //31
                {
                    priceStudio = 50;
                    priceDouble = 65;
                    priceSuite = 75;


                    if (nights > 7 && month.Equals("October"))
                    {
                        discountPercentsStudio = 5;
                        nightsStudio = nights - 1;
                    }
                    else if (nights > 7)
                    {
                        discountPercentsStudio = 5;
                    }
                    else
                    {
                        discountPercentsStudio = 0;
                    }

                }
                else if (month.Equals("June") ||         //30
        month.Equals("September"))      //30
                {

                    priceStudio = 60;
                    priceSuite = 82;
                    priceDouble = 72;

                    if (nights > 7 && month.Equals("September"))
                    {
                        nightsStudio = nights - 1;
                    }

                    if (nights > 14)
                    {
                        discountPercentsDouble = 10;
                    }
                    else
                    {
                        discountPercentsDouble = 0;
                    }

                }
                else if (month.Equals("July") ||          //31
         month.Equals("August") ||         //31
         month.Equals("December"))         //31   215
                {
                    priceStudio = 68;
                    priceDouble = 77;
                    priceSuite = 89;

                    if (nights > 14)
                    {
                        discountPercentsSuite = 15;
                    }
                    else
                    {
                        discountPercentsSuite = 0;
                    }

                }


                double endPriceStudio = Math.Round(nightsStudio * priceStudio * ((100 - discountPercentsStudio) / 100.0), 2, MidpointRounding.AwayFromZero);
                double endPriceDoble = Math.Round(nightsDouble * priceDouble * ((100 - discountPercentsDouble) / 100.0), 2, MidpointRounding.AwayFromZero);
                double endPriceSuite = Math.Round(nightsSuite * priceSuite * ((100 - discountPercentsSuite) / 100.0), 2, MidpointRounding.AwayFromZero);


                Console.WriteLine($"Studio: {endPriceStudio:0.#0} lv.");
                Console.WriteLine($"Double: {endPriceDoble:0.#0} lv.");
                Console.WriteLine($"Suite: {endPriceSuite:0.#0} lv.");

            }
        }
    }
}
