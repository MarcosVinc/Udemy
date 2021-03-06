﻿using System;
using System.Globalization;

namespace ExerciciosSobreEstruturaCondicional
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
                    case 8:
                        Console.Clear();
                        Exercicio8();
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
                            case 8:
                                Console.Clear();
                                Exercicio8();
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
            Console.WriteLine(" Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.");
            Console.WriteLine("");
            int numero = 0;
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero >= 0)
                {
                    Console.WriteLine("| -----------------|");
                    Console.WriteLine("Não Negativo");
                    Console.WriteLine("| -----------------|");
                }
                else
                {
                    Console.WriteLine("| -----------------|");
                    Console.WriteLine("Negativo");
                    Console.WriteLine("| -----------------|");
                }

            }
            else
            {
                Console.WriteLine("Ação invalida: ");
                Console.WriteLine("Aperte enter para voltar ao exercicio");
                Console.ReadLine();
                Console.Clear();
                Exercicio1();
            }
            TelaVoltar();
        }

        public static void Exercicio2()
        {
            Console.WriteLine("Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.");
            Console.WriteLine("");
            int parouimpar = 0;
            if (int.TryParse(Console.ReadLine(), out parouimpar))
            {
                if (parouimpar % 2 != 0)
                {
                    Console.WriteLine("| -----------------|");
                    Console.WriteLine("| " + "Impar" + "  |");
                    Console.WriteLine("| -----------------|");
                }
                else
                {
                    Console.WriteLine("| -----------------|");
                    Console.WriteLine("|    " + "Par" + "  |");
                    Console.WriteLine("| -----------------|");
                }

            }
            else
            {
                Console.WriteLine("Ação invalida: ");
                Console.WriteLine("Aperte enter para voltar ao exercicio");
                Console.ReadLine();
                Console.Clear();
                Exercicio2();
            }
            TelaVoltar();

        }
        public static void Exercicio3()
        {

            Console.WriteLine("Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem 'Sao Multiplos' ou 'Nao sao Multiplos',");
            Console.WriteLine("indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.");

            Console.WriteLine("");
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("| -----------------|");
                Console.WriteLine("São Multiplos");
                Console.WriteLine("| -----------------|");
            }
            else
            {
                Console.WriteLine("| -----------------|");
                Console.WriteLine("Não são multiplos");
                Console.WriteLine("| -----------------|");
            }

            TelaVoltar();
        }

        public static void Exercicio4()
        {
            Console.WriteLine("Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode");
            Console.WriteLine("começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.");
            Console.WriteLine("");
            Console.Write("Horário de inicio : ");
            int horaInicial = int.Parse(Console.ReadLine());
            Console.Write("Horário Final : ");
            int horaFinal = int.Parse(Console.ReadLine());

            int duracaoHora;
            int duracaoDia;
            int duracaoMinuto;

            if (horaInicial < horaFinal)
            {
                duracaoHora = horaInicial - horaFinal;

            }

            else
            {
                duracaoHora = 24 - horaInicial + horaFinal;
                duracaoMinuto = 60 * duracaoHora;
                duracaoDia = duracaoHora / 24;
                Console.WriteLine("| ------------------------------------------- |");
                Console.WriteLine($"O JOGO DUROU {duracaoHora} HORA(S)");
                Console.WriteLine($"O JOGO DUROU {duracaoMinuto} MINUTO(S)");
                Console.WriteLine($"O JOGO DUROU {duracaoDia} DIA(S)");
                Console.WriteLine("| ------------------------------------------- |");

            }

            TelaVoltar();
        }
        public static void Exercicio5()
        {
            Console.WriteLine("Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.");
            Console.WriteLine("A seguir, calcule e mostre o valor da conta a pagar.");
            Console.WriteLine("");

            Console.WriteLine("| ---------------------------------------------- |");
            Console.WriteLine("| CODIGO           ESPECIFICAÇÃO          PREÇO  |");
            Console.WriteLine("| ---------------------------------------------- |");
            Console.WriteLine("|   1             Cachorro Quente       R$: 4,00 |");
            Console.WriteLine("|   2             X-Salada              R$: 4,50 |");
            Console.WriteLine("|   3             X-Bacon               R$: 5,00 |");
            Console.WriteLine("|   4             Torrada simples       R$: 2,00 |");
            Console.WriteLine("|   5             Refrigerante          R$: 1,50 |");
            Console.WriteLine("| ---------------------------------------------- |");
            Console.WriteLine("");
            Console.WriteLine("Qual e o produto que você quer, digite seu codigo ? ");
            int produto = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual e a quantidade produto que você quer ? ");
            int quantidade = int.Parse(Console.ReadLine());

            if (produto == 1)
            {
                double precoDoProduto = 4.00;
                double precoFinal = quantidade * precoDoProduto;
                Console.WriteLine($"Total: R$ {precoFinal:f2}");
            }
            else if (produto == 2)
            {
                double precoDoProduto = 4.50;
                double precoFinal = quantidade * precoDoProduto;
                Console.WriteLine($"Total: R$ {precoFinal:f2}");


            }
            else if (produto == 3)
            {
                double precoDoProduto = 5.00;
                double precoFinal = quantidade * precoDoProduto;
                Console.WriteLine($"Total: R$ {precoFinal:f2}");


            }
            else if (produto == 4)
            {
                double precoDoProduto = 2.00;
                double precoFinal = quantidade * precoDoProduto;
                Console.WriteLine($"Total: R$ {precoFinal:f2}");


            }
            else if (produto == 5)
            {
                double precoDoProduto = 1.50;
                double precoFinal = quantidade * precoDoProduto;
                Console.WriteLine($"Total: R$ {precoFinal:f2}");


            }
            else
            {
                Console.WriteLine("Produto não reconhecido, por favor digite ENTER para ver o catalogo novamente");
                Console.ReadLine();
                Console.Clear();
                Exercicio5();

            }
            TelaVoltar();
        }
        public static void Exercicio6()
        {
            Console.WriteLine("Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos");
            Console.WriteLine("seguintes intervalos([0, 25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em");
            Console.WriteLine("nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.");
            Console.WriteLine("");
            Console.Write("Digite o valor: ");
            double valor = 0;
            if (double.TryParse(Console.ReadLine(), out valor))
            {
                if (valor < 0.0 || valor > 100.0)
                {
                    Console.WriteLine("Fora do intervalo");

                }
                else if (valor <= 25.0)
                {
                    Console.WriteLine("Intervalo (0,25)");
                }
                else if (valor <= 50.0)
                {
                    Console.WriteLine("Intervalo (25,50)");
                }
                else if (valor <= 75.0)
                {
                    Console.WriteLine("Intervalo (50,75)");
                }
                else
                {
                    Console.WriteLine("Intervalo (75,100)");

                }
            }
            else
            {
                Console.WriteLine("Ação invalida, precione ENTER para voltar ao exercicio: ");
                Console.ReadLine();
                Console.Clear();
                Exercicio6();

            }
            TelaVoltar();
        }
        public static void Exercicio7()
        {
            Console.WriteLine("Esse exercicio foi feito usando VETOR");
            Console.WriteLine("Leia 2 valores com uma casa decimal (X e Y),");
            Console.WriteLine("que devem representar as coordenadas de um ponto em um plano.");
            Console.WriteLine("A seguir determine qual o quadrante ao qual pertence o ponto,");
            Console.WriteLine("ou se está sobre um dos eixor cartesianos ou na origem (x=y=0)");
            Console.WriteLine("");
            string[] numero = Console.ReadLine().Split(" ");
            double nun1 = int.Parse(numero[0], CultureInfo.InvariantCulture);
            double nun2 = int.Parse(numero[1], CultureInfo.InvariantCulture);
            if (nun1 == 0.0 && nun2 == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (nun1 == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (nun2 == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (nun1 > 0.0 && nun2 > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (nun1 < 0.0 && nun2 > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (nun1 < 0.0 && nun2 < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

        }
        public static void Exercicio8() 
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
/* public static void Exercicio(){}
 */
