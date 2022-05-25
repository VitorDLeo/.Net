using System;

namespace URI_ex_1134
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int opc = int.Parse(Console.ReadLine());

            while (opc != 4)
            {
                if (opc == 1)
                {
                    alcool += 1;
                }
                else if (opc == 2)
                {
                    gasolina += 1;
                }
                else if (opc == 3)
                {
                    diesel += 1;
                }
                opc = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
