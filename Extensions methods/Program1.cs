using Course.Extensions;
using System;


namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = new DateTime(2023, 06, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}