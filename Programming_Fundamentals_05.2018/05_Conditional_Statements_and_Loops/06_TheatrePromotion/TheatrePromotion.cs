using System;

namespace _06_TheatrePromotion
{
    class TheatrePromotion
    {
        static void Main(string[] args)
        {

            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ticketPrice = 0;
            if (-1000 <= age && age <= 1000)
            {
                if (typeOfDay.Equals("Weekday"))
                {
                    if (0 <= age && age <= 18)
                    {
                        ticketPrice = 12;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else if (18 < age && age <= 64)
                    {
                        ticketPrice = 18;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else if (64 < age && age <= 122)
                    {
                        ticketPrice = 12;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }

                }
                else if (typeOfDay.Equals("Weekend"))
                {
                    if (0 <= age && age <= 18)
                    {
                        ticketPrice = 15;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else if (18 < age && age <= 64)
                    {
                        ticketPrice = 20;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else if (64 < age && age <= 122)
                    {
                        ticketPrice = 15;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }

                }
                else if (typeOfDay.Equals("Holiday"))
                {
                    if (0 <= age && age <= 18)
                    {
                        ticketPrice = 5;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else if (18 < age && age <= 64)
                    {
                        ticketPrice = 12;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else if (64 < age && age <= 122)
                    {
                        ticketPrice = 10;
                        Console.WriteLine($"{ticketPrice}$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }

                }
                else
                {
                }

            }

        }
    }
}
