using Course.Services;
using System;
using System.ComponentModel;

namespace Course
{
    class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Max;

            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}