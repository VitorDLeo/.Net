using System;

namespace EntradaDeDados_partII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char s = char.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double alt = double.Parse(vet[3]);

            Console.WriteLine("---------------------");
            Console.WriteLine(n1);
            Console.WriteLine(s);
            Console.WriteLine(f);
            Console.WriteLine(nome + " " + sexo + " " + idade + " " + alt);
        }
    }
}
