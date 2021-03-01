using System;

namespace ExerciciosSobreEstruturaRepetitivaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void TelaInicial()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Exercicio 1      digite 1");
            Console.WriteLine("Exercicio 2      digite 2");
            Console.WriteLine("Exercicio 3      digite 3");
            Console.WriteLine("Exercicio 4      digite 4");
            Console.WriteLine("Exercicio 5      digite 5");
            Console.WriteLine("Exercicio 6      digite 6");
            Console.WriteLine("Exercicio 7      digite 7");
            Console.WriteLine("Exercicio 8      digite 8");
            Console.WriteLine("--------------------------");
            int esc = 0;
            if (int.TryParse(Console.ReadLine(), out esc))
            {
                switch (esc)
                {
                    case 1:
                        Console.Clear();
                        Exercicio1();
                        break;
                    case 2:
                        Console.Clear();
                        Exercicio2();
                        break;
                    case 3:
                        Console.Clear();
                        Exercicio3();
                        break;
                    case 4:
                        Console.Clear();
                        Exercicio4();
                        break;
                    case 5:
                        Console.Clear();
                        Exercicio5();
                        break;
                    case 6:
                        Console.Clear();
                        Exercicio6();
                        break;
                    case 7:
                        Console.Clear();
                        Exercicio7();
                        break;
                  
                }

            }

            Console.WriteLine("Numero Invalido, precione ENTER para voltar");
            Console.ReadLine();
            Console.Clear();
            TelaInicial();

        }
        public static void TelaVoltar()
        {
            Console.WriteLine("");
            Console.WriteLine("Precione 0 para voltar a tela inicial ou 1 para escolher um exercicio: ");
            int esc = 0;
            if (int.TryParse(Console.ReadLine(), out esc))
            {
                if (esc == 0)
                {
                    Console.Clear();
                    TelaInicial();
                }
                else if (esc == 1)
                {
                    Console.Clear();
                    Console.WriteLine("|-------------------------------|");
                    Console.WriteLine("|" + "Qual exercicio quer ver ?" + "|");
                    Console.WriteLine("|-------------------------------|");
                    int exer1 = 0;
                    if (int.TryParse(Console.ReadLine(), out exer1))
                    {
                        switch (exer1)
                        {
                            case 1:
                                Console.Clear();
                                Exercicio1();
                                break;
                            case 2:
                                Console.Clear();
                                Exercicio2();
                                break;
                            case 3:
                                Console.Clear();
                                Exercicio3();
                                break;
                            case 4:
                                Console.Clear();
                                Exercicio4();
                                break;
                            case 5:
                                Console.Clear();
                                Exercicio5();
                                break;
                            case 6:
                                Console.Clear();
                                Exercicio6();
                                break;
                            case 7:
                                Console.Clear();
                                Exercicio7();
                                break;
                          
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Número invalido.");
                    Console.Write("Precione enter");
                    Console.ReadLine();
                    TelaInicial();

                }
            }
            else
            {
                Console.WriteLine("Ação invalida");
                Console.Write("Precione enter");
                Console.ReadLine();
                TelaVoltar();
            }

        }
        public static void Exercicio1() 
        {
            Console.WriteLine("Leia um valor inteiro X (1 <= X <= 1000).");
            Console.WriteLine("Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso");
            Console.WriteLine("");
            int x = 0;
            if (int.TryParse(Console.ReadLine(), out x))
            {
                for (int i = 1; i <= x; i++) 
                {
                    if (i % 2 != 0) 
                    {
                        Console.WriteLine("");
                        Console.WriteLine(i);
                    }
                }

            }
            else 
            {
                Console.WriteLine("Ação invalida");
                Console.Write("Precione enter");
                Console.ReadLine();
                Exercicio1();
            }
        }
        public static void Exercicio2() { }
        public static void Exercicio3() { }
        public static void Exercicio4() { }
        public static void Exercicio5() { }
        public static void Exercicio6() { }
        public static void Exercicio7() { }

    }
}

/*public static void Exercicio(){}
 */
