using System;

namespace _06_StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {

            string a = Console.ReadLine();
            string b = Console.ReadLine();
            object c = a + " " + b;
            string d = (string)c;

            Console.WriteLine($"{d}");
        }
    }
}
