﻿using System;
using System.Globalization;

namespace Course
{
    class Programa
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}