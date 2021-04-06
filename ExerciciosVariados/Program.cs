using System;
using System.Globalization;

namespace ExerciciosVariados
{
    class Program
    {
        static void Main(string[] args)
        {
            TelaInicial();
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

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome,  preco, quantidade);

            Console.WriteLine();
            Console.Write($"Dados do produto: {p}");

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionados ao estoque");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine($"Dados do produto: {p}");

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removidos ao estoque");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            Console.WriteLine($"Dados do produto: {p}");

        }
        public static void Exercicio2() 
        {
        
        }
    }
}
/* public static void Exercicio(){}
 */
