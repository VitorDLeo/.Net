using System;
using System.Globalization;

namespace URI_ex_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMBER, horasTrabalhadas;
            double valorHora, SALARY;

            NUMBER = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SALARY = horasTrabalhadas * valorHora;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
