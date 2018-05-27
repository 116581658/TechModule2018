﻿using System;

namespace _07_ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            int c = b;
            b = a;
            a = c;

            Console.WriteLine($"After:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
