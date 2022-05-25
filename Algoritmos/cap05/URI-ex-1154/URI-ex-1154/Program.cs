using System;
using System.Globalization;

namespace URI_ex_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, media;
            int count;

            soma = 0;
            media = 0;
            count = 0;

            idade = int.Parse(Console.ReadLine());

            while(idade > 0)
            {
                soma += idade;
                count += 1;
                idade = int.Parse(Console.ReadLine());
            }

            media = (double) soma / count;

            Console.WriteLine(media.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
