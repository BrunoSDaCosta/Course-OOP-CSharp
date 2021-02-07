using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CourseII
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qauntidade: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do produto " + p );
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtde);
            
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
            
            Console.WriteLine();
            Console.Write("Digite o número de produto a ser removido do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtde);
            Console.WriteLine("Dados Atualizados: " + p);

            Console.ReadLine();

        }
       
    }
}
