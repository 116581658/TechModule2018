using System;

namespace _09_CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {

            string something = Console.ReadLine();
            int integerCounter = 0;
            int integerValue;

            if (something.Length <= 7)
            {

                while (int.TryParse(something, out integerValue) && integerCounter < 100)
                {
                    integerCounter++;
                    something = Console.ReadLine();
                }

                Console.WriteLine(integerCounter);

            }

        }
    }
}
