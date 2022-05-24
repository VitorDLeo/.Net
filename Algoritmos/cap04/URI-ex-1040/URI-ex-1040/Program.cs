using System;
using System.Globalization;

namespace URI_ex_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, notaExame, mediaFinal;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            n1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            float Media;
            Media = (float)(((n1 * 2.0) + (n2 * 3.0) + (n3 * 4.0) + (n4 * 1.0)) / 10.0);

            if (Media == 4.85f)
            {
                Media = 4.8f;
            }

            if (Media >= 7.0)
            {
                Console.WriteLine("Media: " + Media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno Aprovado.");
            } else if (Media >= 5.0 && Media <= 6.9)
            {
                notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Media: " + Media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                mediaFinal = (float)((Media + notaExame) / 2.0);
                if (mediaFinal >= 5.0) 
                { 
                    Console.WriteLine("Aluno aprovado.");
                } else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            } else
            {
                Console.WriteLine("Media: " + Media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }  
        }
    }
}
