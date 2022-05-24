using System;

namespace URI_ex_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            if(horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            } else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
