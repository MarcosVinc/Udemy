using System;

namespace ProvaPraticaDeLogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ProvaPraticaDeLogicaDeProgramacao();
        }
        public static void ProvaPraticaDeLogicaDeProgramacao()
        {

            Console.WriteLine("---------- Prova Prática de Lógica de Programação  -----------");
            Console.WriteLine("|                                                            |");
            Console.WriteLine("| Exercicio 1                                        Digite 1|");
            Console.WriteLine("| Exercicio 2                                        Digite 2|");
            Console.WriteLine("| Exercicio 3                                        Digite 3|");
            Console.WriteLine("|------------------------------------------------------------|");


            int exercicios = 0;
            if (int.TryParse(Console.ReadLine(), out exercicios))
            {

                if (exercicios == 1)
                {
                    Console.Write("Qual exercicio, 1a ou 1b: ");
                    string aoub = Console.ReadLine();
                    if (aoub.ToLower() == "a")
                    {
                        Console.Clear();
                        Exercicio1a();
                    }
                    else if (aoub.ToLower() == "b")
                    {
                        Console.Clear();
                        Exercicio1b();
                    }
                    else
                    {
                        Console.WriteLine("Exercicio invalido!");
                        TelaParaVoltar();
                    }
                }
                else if (exercicios == 2)
                {
                    Console.Write("Qual exercicio, 2a ou 2b: ");
                    string aoub = Console.ReadLine();
                    if (aoub.ToLower() == "a")
                    {
                        Console.Clear();
                        Exercicio2a();
                    }
                    else if (aoub.ToLower() == "b")
                    {
                        Console.Clear();
                        Exercicio2b();

                    }
                    else
                    {
                        Console.WriteLine("Exercicio invalido!");
                        TelaParaVoltar();
                    }

                }
                else if (exercicios == 3)
                {
                    Console.Write("Qual exercicio, 3a ou 3b: ");
                    string aoub = Console.ReadLine();
                    if (aoub.ToLower() == "a")
                    {
                        Console.Clear();
                        Exercicio3a();
                    }
                    else if (aoub.ToLower() == "b")
                    {
                        Console.Clear();
                        Exercicio2b();

                    }
                    else
                    {
                        Console.WriteLine("Exercicio invalido!");
                        TelaParaVoltar();
                    }

                }

            }
        }
        public static void TelaParaVoltar()
        {
            Console.WriteLine("");
            Console.Write("Digite 0 para voltar a tela inicial, ou va diretamente para um exercicio colocando o numero dele aqui :");
            double esc = 0;
            if (double.TryParse(Console.ReadLine(), out esc))
            {
                if (esc == 0)
                {
                    Console.Clear();
                    ProvaPraticaDeLogicaDeProgramacao();
                }
                else if (esc == 1)
                {
                    Console.Write("Qual exercicio, 1a ou 1b: ");
                    string aoub = Console.ReadLine();
                    if (aoub.ToLower() == "a")
                    {
                        Console.Clear();
                        Exercicio1a();
                    }
                    else if (aoub.ToLower() == "b")
                    {
                        Console.Clear();
                        Exercicio1b();
                    }
                    else
                    {
                        Console.WriteLine("Exercicio invalido!");
                        TelaParaVoltar();
                    }

                }
                else if (esc == 2)
                {
                    Console.Write("Qual exercicio, 2a ou 2b: ");
                    string aoub = Console.ReadLine();
                    if (aoub.ToLower() == "a")
                    {
                        Console.Clear();
                        Exercicio2a();
                    }
                    else if (aoub.ToLower() == "b")
                    {
                        Console.Clear();
                        Exercicio2b();
                    }
                    else
                    {
                        Console.WriteLine("Exercicio invalido!");
                        TelaParaVoltar();
                    }

                }
                else if (esc == 3)
                {
                    Console.Write("Qual exercicio, 3a ou 3b: ");
                    string aoub = Console.ReadLine();
                    if (aoub.ToLower() == "a")
                    {
                        Console.Clear();
                        Exercicio3a();
                    }
                    else if (aoub.ToLower() == "b")
                    {
                        Console.Clear();
                        Exercicio1b();
                    }
                    else
                    {
                        Console.WriteLine("Exercicio invalido!");
                        TelaParaVoltar();
                    }

                }
            }


        }

        public static void Exercicio1a()
        {
            Console.WriteLine("Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1");
            Console.WriteLine("código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago");
            Console.WriteLine("");
            Console.Write("Digite o código da peça 1: ");
            int cod1 = int.Parse(Console.ReadLine());
            Console.Write("número de peça 1: ");
            int np1 = int.Parse(Console.ReadLine());
            Console.Write("valor unitário de cada peça 1: ");
            double valorUn1 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Digite o código da peça 2:  ");
            int cod2 = int.Parse(Console.ReadLine());
            Console.Write("número de peça 2: ");
            int np2 = int.Parse(Console.ReadLine());
            Console.Write("valor unitário de cada peça 2:  ");
            double valorUn2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double calculo = ((valorUn1 * np1) + (valorUn2 * np2));
            Console.WriteLine($"Valor a pagar  R$:{calculo:F2}");

            Console.WriteLine("");
            TelaParaVoltar();


        }

        public static void Exercicio1b()
        {
            Console.WriteLine("Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais");
            Console.WriteLine("");
            Console.WriteLine("Digite o raio do circulo");
            double raio = 0;
            if (double.TryParse(Console.ReadLine(), out raio))
            {
                double area = (3.14159 * (raio * raio));
                Console.WriteLine($"A = {area:f4}");

            }

            Console.WriteLine("");
            TelaParaVoltar();


        }

        public static void Exercicio2a()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("CODIGO             ESPECIFICAÇÃO                PREÇO");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1                 Cachorro Quente             R$:4.00");
            Console.WriteLine("2                 X-Salada                    R$:4.50");
            Console.WriteLine("3                 X-Bacon                     R$:5.00");
            Console.WriteLine("4                 Torrada Simples             R$:2.00");
            Console.WriteLine("5                 Refrigerantes               R$:1.50");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("");
            Console.WriteLine("Com base na tabela de preços a cima, faça um programa que leia o código de um item e a");
            Console.WriteLine("quantidade deste item.A seguir, calcule e mostre o valor da conta a pagar.");
            Console.WriteLine("");
            Console.Write("Qual e o código do item que deseja: ");
            int codItem = int.Parse(Console.ReadLine());
            Console.Write($"Qual e a quantidade do item você quer : ");
            int quantItem = int.Parse(Console.ReadLine());

            if (codItem == 1)
            {
                double calc = quantItem * 4;
                Console.WriteLine($"Entrada: {codItem}, {quantItem}");
                Console.WriteLine($"Saida: R$: {calc}");

            }
            else if (codItem == 2)
            {
                double calc = quantItem * 4.50;
                Console.WriteLine($"Entrada: {codItem}, {quantItem}");
                Console.WriteLine($"Saida: R$: {calc}");

            }
            else if (codItem == 3)
            {
                double calc = quantItem * 5;
                Console.WriteLine($"Entrada: {codItem}, {quantItem}");
                Console.WriteLine($"Saida: R$: {calc}");

            }
            else if (codItem == 4)
            {
                double calc = quantItem * 2;
                Console.WriteLine($"Entrada: {codItem}, {quantItem}");
                Console.WriteLine($"Saida: R$: {calc}");

            }
            else if (codItem == 5)
            {
                double calc = quantItem * 1.50;
                Console.WriteLine($"Entrada: {codItem}, {quantItem}");
                Console.WriteLine($"Saida: R$: {calc}");

            }
            else
            {
                Console.WriteLine("Deu Erro!");
                Console.WriteLine("Precione ENTER para voltar ao exercicio");
                Console.ReadLine();
                Console.Clear();
                Exercicio2a();

            }

            Console.WriteLine("");
            TelaParaVoltar();
        }
        public static void Exercicio2b()
        {
            Console.WriteLine("Ler os valores dos três coeficientes 'a', 'b' e 'c'de uma equação do segundo grau (AX*AX + BX + C = 0)");
            Console.WriteLine("Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara ");
            Console.WriteLine("veja abaixo.Se a equação não possuir raízeso valor de 'a' não pode ser zero, ");
            Console.WriteLine("e o valor de 'delta' não pode ser negativo, mostrar uma mensagem 'Impossivel calcular'");
            Console.WriteLine("");
            Console.WriteLine("Digite o aX: ");
            double ax = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o bX: ");
            double bx = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o cX: ");
            double cx = double.Parse(Console.ReadLine());

            double delta = ((bx * bx) - (4 * ax * cx));

            if (ax == 0 || delta < 0)
            {
                Console.WriteLine($"aX: {ax} , delta: {delta}");
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double bhaskara = (-1 * (bx));
                double bhaskara2 = (float)Math.Sqrt(delta);
                double bhaskara3 = 2 * ax;
                double x1 = ((bhaskara + bhaskara2) / bhaskara3);
                double x2 = ((bhaskara - bhaskara2) / bhaskara3);

                Console.WriteLine($"X1: {x1:f4}");
                Console.WriteLine($"X2: {x2:f4}");


            }
            Console.WriteLine("");
            TelaParaVoltar();
        }
        public static void Exercicio3a()
        {
            Console.WriteLine("Escreva um programa que repita a leitura de uma senha até que ela seja válida.");
            Console.WriteLine("Para cada leitura de senha incorreta informada, escrever a mensagem 'Senha Invalida'");
            Console.WriteLine("Quando a senha for informada corretamente deve ser impressa a mensagem 'Acesso Permitido' e o algoritmo encerrado");
            Console.WriteLine("Considere que a senha correta é o valor 2002.");
            Console.WriteLine("");
            Console.WriteLine("Digite a senha: ");
            double senha = double.Parse(Console.ReadLine());

            while (senha < 2002 || senha > 2002)
            {
                Console.WriteLine("Senha invalida:");
                senha = double.Parse(Console.ReadLine());

            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("|  Acesso permitido   |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("");
            TelaParaVoltar();
        }
}
