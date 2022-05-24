using System;

namespace URI_ex_1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);

            if((B > C && D > A) && (C + D > A + B))
            {
                Console.WriteLine("Valores aceitos");
            } else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
