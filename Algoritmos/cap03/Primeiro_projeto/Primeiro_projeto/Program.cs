using System;
using System.Globalization;

namespace Primeiro_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.422345;
            double resultado = 10.35467;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Äprendendo DotNet");

            Console.WriteLine(x.ToString("F2"));

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Resultado = " + resultado);
            Console.WriteLine("O valor do troco e " + resultado + " Reais");
            Console.WriteLine("o valor do troco e " + resultado.ToString("F2", CultureInfo.InvariantCulture) + " Reais");
        }
    }
}
