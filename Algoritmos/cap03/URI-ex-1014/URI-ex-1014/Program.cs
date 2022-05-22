using System;
using System.Globalization;

namespace URI_ex_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, consumoMedio;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumoMedio = X / Y;

            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
