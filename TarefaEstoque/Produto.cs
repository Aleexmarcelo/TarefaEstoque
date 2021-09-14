using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TarefaEstoque
{
     class Produto
    {
        //Criada as variaveis necessarias
        public string Nome;
        public double Preco;
        public int Quantidade;
        //Responsavel pelos preços do usuario em estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        //Responsavel por somar numeros do usuario
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        //Responsavel por subtrair numeros do usuario
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        //Pega todas as informaçoes, e printa no console no final de todo o processo
        public override string ToString()
        {
            return Nome
                + " , R$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " , "
                + Quantidade 
                + " unidades , Total: R$"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
