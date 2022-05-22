using System;
using System.Globalization;

namespace ex_resol_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double idadeA, idadeB, media;
            string nomeA, nomeB;

            Console.Write("Nome e idade A: ");
            string[] valores = Console.ReadLine().Split(' ');
            nomeA = valores[0];
            idadeA = double.Parse(valores[1]);

            Console.Write("Nome e Idade B: ");
            valores = Console.ReadLine().Split(' ');
            nomeB = valores[0];
            idadeB = double.Parse(valores[1]);

            media = (idadeA + idadeB) / 2.00;

            Console.WriteLine("A idade media de " + nomeA + " e " + nomeB + " e de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos!");
        }
    }
}
