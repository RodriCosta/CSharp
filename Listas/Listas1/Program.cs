using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Listas1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Lista = new List<string>();

            //declaração inline de valores
            List<string> Lista2 = new List<string>() {"José", "Abner" };

            //adiciona valor a lista por ordem de declaração
            Lista.Add("Rodrigo");
            Lista.Add("Maria");
            Lista.Add("Fabio");
            Lista.Add("Alexandre");

            //adiciona valor a lista em posicao que voce determina pelo id da lista
            Lista.Insert(2,"Andre");

            foreach (string obj in Lista)
            {

                Console.WriteLine(obj);

            }
            //Lambda passada como argumento do método find, quero o obj x tal que o x na posição zero seja igual a 'A'.
            string s1 = Lista.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome com A: "+ s1);

            //ultimo nome com a letra 'A'.
            string s2 = Lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo nome com A: " + s2);

            //posicao do primeiro nome com a letra 'A' no array.
            int s3 = Lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posicao do Primeiro nome com A: " + s3);

            //posicao do ultimo nome com a letra 'A' no array.
            int s4 = Lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posicao do  Ultimo nome com A: " + s4);

            //traz o tamanho inteiro da lista
            Console.WriteLine("List Coutn: " + Lista.Count);

            //coloca na lista resultado filtro do tipo string a lista original filtrada com a condição que todo x (item da lista original), seja igual a 5
            List<string> ResultadoFiltro = Lista.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------------------");
            foreach (var item in ResultadoFiltro)
            {
                Console.WriteLine(item);
            }

            //remove da lista pelo nome
            Lista.Remove("Alexandre");
            Console.WriteLine("-----------------------------");
            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }

            //remove da lista por condição, no caso todo x(item da lista), que comeca com 'A', é removido(os itens sao lidos como arrays de letras em lambda)
            Lista.RemoveAll(x => x[0] == 'A');
            Console.WriteLine("-----------------------------");
            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }

            //remove por posição na lista
            Lista.RemoveAt(0);
            Console.WriteLine("-----------------------------");
            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }

            //remove de uma posição até a outra(sobra so a maria que é zero, fiz de um ate a posição um mesmo, conta do primeiro numero ja deletando).
            Lista.RemoveRange(1,1);
            Console.WriteLine("-----------------------------");
            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            
        }
    }
}
