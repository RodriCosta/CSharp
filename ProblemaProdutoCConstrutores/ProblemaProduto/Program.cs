using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProblemaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRIMEIRAS AULAS
            //Console.WriteLine("Entre os dados do produto: ");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            //Produto p = new Produto(nome, preco);

            ////declaração de valores em linha (só funciona quando temos um construtor padrão).
            //Produto p2 = new Produto { Nome = "Televisao", Preco = 200.00, Quantidade = 5 };
            ////Construtor padrão pré definido na sobrecarga do construtor
            //Produto p3 = new Produto();

            //Console.WriteLine("Dados do produto "+ p);

            //Console.WriteLine();
            //Console.Write("Digite o numero de produtos a serem adicionados: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionaProdutos(qte);
            //Console.WriteLine("Dados Atualizados: " + p);

            //Console.WriteLine();
            //Console.Write("Digite o numero de produtos a serem removidos: ");
            // qte = int.Parse(Console.ReadLine());
            //p.RemoveProdutos(qte);
            //Console.WriteLine("Dados Atualizados: " + p);

            //Console.ReadKey();


            //ENCAPSULAMENTO
            Produto p = new Produto("TV",200.00);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
            Console.ReadKey();
        }
    }
}
