using System;
using System.Globalization;

namespace URI_ex_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora, velocidadeMedia;
            double litrosGasto;

            hora = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            litrosGasto = (hora * velocidadeMedia) / 12.0;

            Console.WriteLine(litrosGasto.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
