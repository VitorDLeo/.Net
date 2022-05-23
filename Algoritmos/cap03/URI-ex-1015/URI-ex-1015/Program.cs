using System;
using System.Globalization;

namespace URI_ex_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet;
            double x1, x2, y1, y2, Distancia;

            vet = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            Distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.00) + Math.Pow(y2 - y1, 2.00));

            Console.WriteLine(Distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
