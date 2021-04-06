using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExerciciosVariados
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto (string nome, double preco, int quantidade) 
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        
        }

        public double ValorProduto()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
            /*
             * Ou Quandidade += quantidade
             */
        }
        public void RemoverProduto(int remover)
        {
            Quantidade = Quantidade - remover;
            /*
             * ou Quandidade -= remover
             */
        }
        public override string ToString()
        {
            return $"Nome {Nome} , $ {Preco}, {Quantidade} unidades, Total " + ValorProduto().ToString("f2", CultureInfo.InvariantCulture);

        }


    }
}
