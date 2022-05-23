using System;
using System.Globalization;

namespace ex_res_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, notaFinal;

            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notaFinal = (n1 + n2) / 2.00;

            if (notaFinal >= 60.0){
                Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO!");
            } else {
                Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO!");
            }
        }
    }
}
