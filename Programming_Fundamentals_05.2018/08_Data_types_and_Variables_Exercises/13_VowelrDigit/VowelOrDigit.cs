
using System;

namespace _13._VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            decimal value2;

            bool digit = decimal.TryParse(num, out value2);
            bool vowel = num.Equals("a") ||
                num.Equals("e") ||
                num.Equals("i") ||
                num.Equals("o") ||
                num.Equals("u");

            if (digit)
            {
                Console.WriteLine("digit");
            }
            else if (vowel)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
