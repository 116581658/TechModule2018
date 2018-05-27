using System;

namespace _10_CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {

            int centuries = int.Parse(Console.ReadLine());

            byte years = 100;
            int yearsInCenturies = centuries * years;
            float daysInYear = 365.2422f;
            int daysInCenturies =(int)(yearsInCenturies * daysInYear);
            byte hoursInDay = 24;
            int hoursInCenturies = daysInCenturies * hoursInDay;
            byte minutesInHour = 60;
            int minutesInCenturies = hoursInCenturies * minutesInHour; 
            byte secondsInMinute = 60;
            long secondsInCenturies = (long)minutesInCenturies * secondsInMinute;
            short miliseconds = 1000;
            long milisecondsInCenturies = secondsInCenturies * miliseconds;
            short microseconds = 1000;
            long microsecondsInCenturies = milisecondsInCenturies * microseconds;
            short nanoeconds = 1000;
            decimal nanosecondsInCenturies = (decimal)microsecondsInCenturies * nanoeconds;

            Console.WriteLine($"{centuries} centuries = {yearsInCenturies} years = {daysInCenturies} days = {hoursInCenturies} hours = {minutesInCenturies} minutes = {secondsInCenturies} seconds = {milisecondsInCenturies} milliseconds = {microsecondsInCenturies} microseconds = {nanosecondsInCenturies} nanoseconds");
        }
    }
}
