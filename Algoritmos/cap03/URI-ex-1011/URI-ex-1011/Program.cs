using System;
using System.Globalization;

namespace URI_ex_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, VOLUME;
            double pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            VOLUME = (double) (4.0 / 3.0) * pi * Math.Pow(R, 3.0);

            Console.WriteLine("VOLUME = " + VOLUME.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
