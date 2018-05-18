using System;

namespace _03_BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            string strMinutes = Console.ReadLine();
            int minutes = int.Parse(strMinutes);
            int thirtyMinutes = 30;
            int minutesInFuture = 0;
            string theTimeInFuture = "";

            if ((0 <= minutes && minutes <= 59) && (0 <= hours && hours <= 23))
            {
                minutesInFuture = minutes + thirtyMinutes;

                if (minutesInFuture > 59)
                {
                    hours++;
                    minutesInFuture -= 60;
                    if (hours > 23)
                    {
                        hours -= 24;
                    }
                }

                string newMinutes = $"{minutesInFuture}";
                if (minutesInFuture < 10)
                {
                    newMinutes = "0" + newMinutes;
                }

                theTimeInFuture = $"{hours}:{newMinutes}";

            }

            Console.WriteLine(theTimeInFuture);


        }
    }
}
