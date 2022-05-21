using System;

namespace FuncoesMatematicas_EquacoesQuadraticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de a: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------");
            double delta = Math.Pow(b, 2.0) - (4 * a * c);
            Console.WriteLine("O valor de delta e = " + delta);

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("------------------------------");
            Console.WriteLine("o valor de x1 = " + x1);
            Console.WriteLine("o valor de x2 = " + x2);
        }
    }
}
