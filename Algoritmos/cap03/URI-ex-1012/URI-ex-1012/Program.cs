using System;
using System.Globalization;

namespace URI_ex_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;
            double pi = 3.14159;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            TRIANGULO = (double) (A * C) / 2.000;
            CIRCULO = (double) pi * Math.Pow(C, 2.000);
            TRAPEZIO = (double) (A + B) * C / 2.000;
            QUADRADO = (double) Math.Pow(B, 2.000);
            RETANGULO = (double)A * B;

            Console.WriteLine("TRIANGULO: " + TRIANGULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + CIRCULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + QUADRADO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + RETANGULO.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
