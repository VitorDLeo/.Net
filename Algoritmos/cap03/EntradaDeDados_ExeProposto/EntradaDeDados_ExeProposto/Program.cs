using System;

namespace EntradaDeDados_ExeProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome complete: ");
            string nomeCompleto = Console.ReadLine();

            Console.Write("Quanto tem na sua casa: ");
            int quartos = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preco de um produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Entre com seu ultimo nome, idade e altura (mesma linha): ");
            string [] vet = Console.ReadLine().Split(" ");

            string lastName = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine("------------------------------");
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
