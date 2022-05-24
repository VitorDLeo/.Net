using System;

namespace ex_resol_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, menor;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            menor = n1;

            if(n2 < n1 && n2 < n3)
            {
                menor = n2;
            } else if(n3 < n1 && n3 < n2)
            {
                menor = n3;
            }
            Console.WriteLine("MENOR = " + menor);
        }
    }
}
