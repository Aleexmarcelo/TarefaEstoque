using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace estoque
{
    class Produto
    {
        //Criada a variavél nome
        private string _nome;
        //Cria as variaveis que irei utilizar get e set
        public double _preco { get; private set; }
        public int _quantidade 
        {    
            get; private set;
        }

        //Construtor
        public Produto (string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Construtor da variavel usando o get e set
        public string Nome
        {
            
            get
            {
                return _nome;
            }       
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //Função que calcula o valor do estoque
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        //Função que adiciona produtos no estoque
        public void AdicionarProduto(int qtd)
        {
            _quantidade += qtd;
        }

        //Função que remove produtos do estoque
        public void RemoverProdutos(int qtd)
        {
            _quantidade = _quantidade - qtd;
        }

        //Retorno do console com todos os dados
        public override string ToString()
        {
            return _nome
            + ",R$"
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ","
            + _quantidade
            + " unidades,Total: R$"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}