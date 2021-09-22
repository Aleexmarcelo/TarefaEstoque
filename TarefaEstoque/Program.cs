using System;
using System.Globalization;

namespace TarefaEstoque
{
   public class Program
    {
        static void Main(string[] arg)
        {
            //Instancia P como um novo produto
            Produto p = new Produto();

            //Pede para que o estoquista entre com os dados de cada produto
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            //Fornece os dados do produto
            Console.WriteLine("Dados do produto: " + p);

            //Pede para que forneça dados de quantidade de produtos novos
            Console.WriteLine("Digite o número de produtos a ser adicionado em estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            //Diz que os dados foram atualizados
            Console.WriteLine("Dados atualizados: " + p);

            //Pede para que o estoquista digite quantos produtos sairam do estoque
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            //Diz que os dados foram atualizados
            Console.WriteLine("Dados atualizados: " +p);
        }
    }
}
