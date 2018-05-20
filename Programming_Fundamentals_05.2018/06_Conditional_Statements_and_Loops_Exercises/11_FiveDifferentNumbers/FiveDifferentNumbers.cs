using System;

namespace _11_FiveDifferentNumbers
{
    class FiveDifferentNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            //int a = 3;
            //int b = 8;

            int min = Math.Min(a, b);
            int max = Math.Max(a, b);

            a = min;
            b = max;
            //Console.WriteLine("a: " + a);
            //Console.WriteLine("b: " + b);


            int differ = b - a;
            //Console.WriteLine("Diff: " + differ);

            /*
             * !!!!!!!!!! INFO: JUDGE doesn't take into account the restriction 
             */

            //if ((-100 <= a && b <= 100) )    [-100...100]
            //{

            if (differ < 4)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = a; i < b; i++)
                {
                    for (int j = i + 1; j < b; j++)
                    {
                        for (int k = j + 1; k < b; k++)
                        {
                            for (int l = k + 1; l < b; l++)
                            {
                                for (int m = l + 1; m <= b; m++)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

        }
    }
}
