using System;

namespace ExeResolved01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da largura do Terreno: ");
            double larg = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura do Terreno: ");
            double alt = double.Parse(Console.ReadLine());

            Console.Write("Preco do metro qudrado? ");
            double preco = double.Parse(Console.ReadLine());

            double area = larg * alt;
            double valor = area * preco;

            Console.WriteLine("Area: " + area.ToString("F2"));
            Console.WriteLine("Preco: " + valor.ToString("F2"));
        }
    }
}
