using System;

namespace URI_ex_1049_ANIMAL
{
    class Program
    {
        static void Main(string[] args)
        {
            // Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível 
            // Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.
            // A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima

            string word1, word2, word3;

            word1 = Console.ReadLine();
            word2 = Console.ReadLine();
            word3 = Console.ReadLine();

            if (word1 == "vertebrado")
            {
                if (word2 == "ave")
                {
                    if (word3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    } if (word3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                } if (word2 == "mamifero")
                {
                    if (word3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    } if (word3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            } if (word1 == "invertebrado")
            {
                if (word2 == "inseto")
                {
                    if (word3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    } if (word3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                } if (word2 == "anelideo")
                {
                    if (word3 == "hematofago")
                    {
                        Console.WriteLine("sanguesuga");
                    } if (word3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            } 
        }
    }
}
