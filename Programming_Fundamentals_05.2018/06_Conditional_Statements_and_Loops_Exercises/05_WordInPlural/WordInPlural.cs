using System;

namespace _05_WordInPlural
{
    class WordInPlural
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            int nounLen = noun.Length;

            bool nounEndsIn_y = noun.EndsWith("y");

            bool nounEndsIn_o = noun.EndsWith("o");
            bool nounEndsIn_ch = noun.EndsWith("ch");
            bool nounEndsIn_s = noun.EndsWith("s");
            bool nounEndsIn_sh = noun.EndsWith("sh");
            bool nounEndsIn_x = noun.EndsWith("x");
            bool nounEndsIn_z = noun.EndsWith("z");

            string nounInPlural = "";
            string suffix = "";

            if (nounEndsIn_y)
            {
                suffix = "ies";
                nounLen -= 1;
                nounInPlural = noun.Substring(0, nounLen);
            }
            else if (nounEndsIn_o || nounEndsIn_s || nounEndsIn_x || nounEndsIn_z || nounEndsIn_ch || nounEndsIn_sh)
            {
                suffix = "es";
                nounInPlural = noun.Substring(0, nounLen);
            }
            else
            {
                suffix = "s";
                nounInPlural = noun.Substring(0, nounLen);

            }

            Console.WriteLine($"{nounInPlural}{suffix}");

        }
    }
}
