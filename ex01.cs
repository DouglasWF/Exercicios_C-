using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero positivo ou negativo?");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 < 0)
            {
                Console.WriteLine("NEGATIVO");
            } else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }
    }

}