using System;
using System.Globalization;

namespace URI_ex_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, raio;
            double n = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = n * (Math.Pow(raio, 2.0));

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
