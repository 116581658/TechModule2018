using System;

namespace _05_ForeignLanguages
{
    class ForeignLanguages
    {
        static void Main(string[] args)
        {


            string country = Console.ReadLine();
            string language = "";

            /*
             * English is spoken in England and USA; Spanish is spoken in Spain, Argentina and Mexico; for the others, we should print "unknown".
             * 
             */


            switch (country)
            {
                case "England":
                case "USA":
                    language = "English";
                    Console.WriteLine(language);
                    break;
                case "Argentina":
                case "Mexico":
                case "Spain":
                    language = "Spanish";
                    Console.WriteLine(language);
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
