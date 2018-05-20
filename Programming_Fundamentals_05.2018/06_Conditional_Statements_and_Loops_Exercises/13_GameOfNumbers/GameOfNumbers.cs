using System;

namespace _13_GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {

            int numN = int.Parse(Console.ReadLine());
            int numM = int.Parse(Console.ReadLine());
            int numMagical = int.Parse(Console.ReadLine());
            int lastN = 0;
            int lastM = 0;
            int sum = 0;
            int combCounter = 0;
            bool isfound = false;


            for (int i = numN; i <= numM; i++)
            {
                for (int j = numN; j <= numM; j++)
                {
                    sum = i + j;
                    if (sum== numMagical)
                    {
                        lastN = i;
                        lastM = j;
                        isfound = true;
                    }
                    combCounter++;
                }
            }


            if (isfound)
            {
                Console.WriteLine($"Number found! {lastN} + {lastM} = {numMagical}");
            }
            else
            {
                Console.WriteLine($"{combCounter} combinations - neither equals {numMagical}");
            }
        }
    }
}
