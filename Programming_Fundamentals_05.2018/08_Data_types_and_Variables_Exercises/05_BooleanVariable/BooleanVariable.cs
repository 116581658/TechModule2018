using System;

namespace _05_BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            //string varia = Console.ReadLine();
            bool varia = bool.Parse( Console.ReadLine());

            if (varia)
            {
                Console.WriteLine("Yes");
            }
            else 
            {
                Console.WriteLine("No");
            }

        }
    }
}
