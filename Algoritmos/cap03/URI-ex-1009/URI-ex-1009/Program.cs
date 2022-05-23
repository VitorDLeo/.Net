using System;
using System.Globalization;

namespace URI_ex_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, totalVendas, TOTAL;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            TOTAL = totalVendas * (15.0 / 100.0) + salario;

            Console.WriteLine("TOTAL = R$ " + TOTAL.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
