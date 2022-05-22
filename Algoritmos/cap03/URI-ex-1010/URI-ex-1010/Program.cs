using System;
using System.Globalization;

namespace URI_ex_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int pc1, pc2, qt1, qt2;
            double valorPc1, valorPc2, total;

            string [] vet = Console.ReadLine().Split(' ');
            pc1 = int.Parse(vet[0]);
            qt1 = int.Parse(vet[1]);
            valorPc1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            pc2 = int.Parse(vet[0]);
            qt2 = int.Parse(vet[1]);
            valorPc2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            total = qt1 * valorPc1 + qt2 * valorPc2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
