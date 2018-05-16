using System;

namespace _05_CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            int charsForMaxHealt = maximumHealth - currentHealth ;
            int charsForMaxEnerty = maximumEnergy - currentEnergy;

            string currHealth = new string('|', currentHealth);
            string maxHealth = new string('.', charsForMaxHealt);
            string currEner = new string('|', currentEnergy);
            string maxEner = new string('.', charsForMaxEnerty);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{currHealth}{maxHealth}|");
            Console.WriteLine($"Energy: |{currEner}{maxEner}|");




        }
    }
}
