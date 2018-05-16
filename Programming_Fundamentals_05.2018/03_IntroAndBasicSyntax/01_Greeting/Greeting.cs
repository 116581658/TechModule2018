using System;

namespace _01_Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What's your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}


