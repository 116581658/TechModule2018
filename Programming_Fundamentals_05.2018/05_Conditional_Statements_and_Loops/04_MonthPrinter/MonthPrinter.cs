using System;

namespace _04_MonthPrinter
{
    class MonthPrinter
    {
        static void Main(string[] args)
        {

            int hours = int.Parse(Console.ReadLine());
            string monthName = "";

            switch (hours)
            {
                case 1:
                    monthName = "January";
                    Console.WriteLine(monthName);
                    break;
                case 2:
                    monthName = "February";
                    Console.WriteLine(monthName);
                    break;
                case 3:
                    monthName = "March";
                    Console.WriteLine(monthName);
                    break;
                case 4:
                    monthName = "April";
                    Console.WriteLine(monthName);
                    break;
                case 5:
                    monthName = "May";
                    Console.WriteLine(monthName);
                    break;
                case 6:
                    monthName = "June";
                    Console.WriteLine(monthName);
                    break;
                case 7:
                    monthName = "July";
                    Console.WriteLine(monthName);
                    break;
                case 8:
                    monthName = "August";
                    Console.WriteLine(monthName);
                    break;
                case 9:
                    monthName = "September";
                    Console.WriteLine(monthName);
                    break;
                case 10:
                    monthName = "October";
                    Console.WriteLine(monthName);
                    break;
                case 11:
                    monthName = "November";
                    Console.WriteLine(monthName);
                    break;
                case 12:
                    monthName = "December";
                    Console.WriteLine(monthName);
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }

        }
    }
}
