using System;
using System.Globalization;

namespace Course
{
    class Programa
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(3, 4, 5);
            int s3 = Calculator.Sum(4, 5, 6, 7, 150);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
