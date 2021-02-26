using System;

namespace CapítuloIntroduçãoàProgramaçãoOrientadaaObjetos
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
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.");
            Console.WriteLine("");
            Console.WriteLine("Dados da primeira pessoa ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.Write("Sexo: ");
            p1.Sexo = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Dados da Segunda pessoa ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());
            Console.Write("Sexo: ");
            p2.Sexo = Console.ReadLine();

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            }

            TelaVoltar();

        }

        public static void Exercicio2()
        {
            Funcionario fun1 = new Funcionario();
            Funcionario fun2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            fun1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            fun1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            fun2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            fun2.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double mediaSalario = (fun1.Salario + fun2.Salario) / 2;
            Console.WriteLine($"Salário médio: {mediaSalario:f2}");


            TelaVoltar();
        }
}
