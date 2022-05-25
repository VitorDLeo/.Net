using System;

namespace EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estrutura de repeticao WHILE

            int x, soma;

            x = int.Parse(Console.ReadLine());
            soma = 0;
            while (x != 0)
            {
                Console.WriteLine("soma = " + soma);
                x = int.Parse(Console.ReadLine());
                soma += x;
            }
        }
    }
}
