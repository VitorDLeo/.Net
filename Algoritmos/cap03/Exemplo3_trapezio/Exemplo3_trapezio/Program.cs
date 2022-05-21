using System;

namespace Exemplo3_trapezio
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, b, B, h;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;

            Console.WriteLine(area);
           
        }
    }
}
