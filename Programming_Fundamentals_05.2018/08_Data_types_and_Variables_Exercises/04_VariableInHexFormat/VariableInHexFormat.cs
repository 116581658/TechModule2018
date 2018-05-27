using System;

namespace _04_VariableInHexFormat
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {

            string num1 = Console.ReadLine();
            int converted = Convert.ToInt32(num1, 16);

            Console.WriteLine($"{converted}");
        }
    }
}
