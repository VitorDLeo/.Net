using System;
using System.Globalization;

namespace ex_resol_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, b, AREA, PERIMETRO, DIAGONAL;

            Console.Write("base(b): ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura(h): ");
            h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AREA = h * b;
            PERIMETRO = 2.00 * (b + h);
            DIAGONAL = Math.Sqrt(Math.Pow(h, 2.0) + Math.Pow(b, 2.0));

            Console.WriteLine("AREA = " + AREA.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + PERIMETRO.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + DIAGONAL.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
