using System;

namespace _14_MagicLetter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {

            char letterOne = char.Parse(Console.ReadLine());
            char letterTwo = char.Parse(Console.ReadLine());
            char letterThree = char.Parse(Console.ReadLine());
            int valueOne = letterOne;
            int valueTwo = letterTwo;
            int valueThree = letterThree;


            for (int i = valueOne; i <= valueTwo; i++)
            {
                for (int j = valueOne; j <= valueTwo; j++)
                {
                    for (int k = valueOne; k <= valueTwo; k++)
                    {
                        if (i == valueThree || j == valueThree || k == valueThree)
                        {
                            continue;
                        }
                        else
                        {
                            char one = (char)i;
                            char two = (char)j;
                            char three = (char)k;
                            Console.Write($"{one}{two}{three} ");

                        }
                    }
                }
            }

            Console.WriteLine();
                        
        }
    }
}
