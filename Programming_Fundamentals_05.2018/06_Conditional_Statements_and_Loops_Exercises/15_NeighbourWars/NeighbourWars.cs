using System;

namespace _15_NeighbourWars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            // Pesho attacks with “Roundhouse kick” on every odd turn
            // Gosho attacks with “Thunderous fist” on every even turn 
            int roundhouseKick = int.Parse(Console.ReadLine()); // Pesho
            int thunderousFist = int.Parse(Console.ReadLine()); // Gosho
            int peshosHealth = 100;
            int goshosHealth = 100;
            int roundNumber = 0;
            string peshosAttack = "Roundhouse kick";
            string goshosAttack = "Thunderous fist";

            int roundCounter = 0;

            if ((0<= roundhouseKick && roundhouseKick <=100) && (0 <= thunderousFist && thunderousFist <= 100))
            {


                while (peshosHealth > 0 && goshosHealth > 0)
                {
                    roundNumber++;
                    roundCounter++;

                    if (roundNumber % 2 == 1) //odd turn
                    {
                        goshosHealth -= roundhouseKick;
                        if (goshosHealth > 0)
                        {
                            Console.WriteLine($"Pesho used {peshosAttack} and reduced Gosho to {goshosHealth} health.");
                        }
                        else
                        {
                            break;
                        }

                    }
                    else //even turn
                    {
                        peshosHealth -= thunderousFist;
                        if (peshosHealth > 0)
                        {
                            Console.WriteLine($"Gosho used {goshosAttack} and reduced Pesho to {peshosHealth} health.");
                        }
                        else
                        {
                            break;
                        }

                    }


                    if (roundCounter == 3)
                    {
                        goshosHealth += 10;
                        peshosHealth += 10;
                        roundCounter = 0;
                    }

                }


                if (peshosHealth > 0)
                {
                    Console.WriteLine($"Pesho won in {roundNumber}th round.");
                }
                else
                {
                    Console.WriteLine($"Gosho won in {roundNumber}th round.");
                }


            }

        }
    }
}
