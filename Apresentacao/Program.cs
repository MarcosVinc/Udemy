using System;

namespace Apresentacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Apresentacao();
        }
        public static void Apresentacao()
        {
            Console.WriteLine("|---------------------------------------------------|");
            Console.WriteLine("| Dificuldades        Problemas         Facilidades |");
            Console.WriteLine("|---------------------------------------------------|");
            Console.WriteLine("| 1                       2                  3      |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|- Precione a tecla referente a o que você deseja  -|");
            Console.WriteLine("|---------------------------------------------------|");
            int esc = 0;
            if (int.TryParse(Console.ReadLine(), out esc))
            {
                switch (esc)
                {
                    case 1:
                        Console.Clear();
                        Dificuldades();
                        break;
                    case 2:
                        Console.Clear();
                        Problamas();
                        break;
                    case 3:
                        Console.Clear();
                        Facilidades();
                        break;

                }


            }

            else
            {
                Console.WriteLine("Ação invalida, precione ENTER para voltar");
                Console.ReadLine();
                Console.Clear();
                Apresentacao();
            }

        }

        public static void Dificuldades()
        {
            Console.WriteLine("25/02/2021");
            Console.WriteLine("for");
        }
        public static void Problamas()
        {
            Console.WriteLine(" 25/02/2021 ");
            Console.WriteLine("Tive que repostar todo o conteudo de uma vez");
            Console.WriteLine("O resitorio ficou de mal e não deixava mas eu fazer nada");


        }
        public static void Facilidades()
        {
            Console.WriteLine("25/02/2021");
            Console.WriteLine("if, else");
            Console.WriteLine("while");
            Console.WriteLine("classe");
            Console.WriteLine("TryParse, e uma delicia fazer!");


        }
    }
}
