using System;
using System.Globalization;

namespace URI_ex_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor;

            valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (valor < 0.00 || valor > 100.00)
            {
                Console.WriteLine("Fora de intervalo");
            } else if (valor <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            } else if (valor <= 75.00)
            {
                Console.WriteLine("Intervalo (50,75]");
            } else if (valor <= 100.00)
            {
                Console.WriteLine("Intervalo (75,100]");
            } 
        }
    }
}
