using System;

namespace _04_Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int nPersons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)nPersons / capacity);
            Console.WriteLine(courses);

        }
    }
}
