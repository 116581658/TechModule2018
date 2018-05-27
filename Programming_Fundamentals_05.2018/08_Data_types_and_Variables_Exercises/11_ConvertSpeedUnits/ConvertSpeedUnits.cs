using System;

namespace _11_ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {

            int distanceInMeters = int.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());
            short mile = 1609;

            int secondsInHour = (hours * 60 * 60) + (minutes * 60) + seconds;

            float kmFromDistance = distanceInMeters / 1000;
            float minInHour = (float)minutes / 60;
            float secInHour = (float)seconds / (60 * 60);
            float hoursFromHMS = hours + minInHour + secInHour;

            float mPerSecond = distanceInMeters / (float)secondsInHour;
            float kmPerHour = kmFromDistance / hoursFromHMS;

            float distInMiles = (float)distanceInMeters / mile;
            float milesPerHour = distInMiles / hoursFromHMS;

            Console.WriteLine($"{mPerSecond}");
            Console.WriteLine($"{kmPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}
