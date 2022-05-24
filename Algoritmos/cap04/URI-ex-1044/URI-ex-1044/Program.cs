using System;

namespace URI_ex_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet;
            int A, B;

            vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if(A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            } else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
