using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> A = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);
            //percorre o conjunto A e imprime na tela
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }
            HashSet<int> B = new HashSet<int>();

            B.Add(3);
            B.Add(4);
            B.Add(5);
            //percorre o conjunto A e imprime na tela
            foreach (int x in B)
            {
                Console.WriteLine(x);
            }
            //adicona todos numeros de B que não contem em A
            //A.UnionWith(B);
            //imprime os numeros de A que contem em B
            //A.IntersectWith(B);
            //remove todos os numeros de A que tem em B 
            //A.ExceptWith(B);

            //percorre o conjunto A e imprime na tela
            //foreach (int x in A)
            //{
            //    Console.WriteLine(x);
            //}
            Console.WriteLine("Digite um numero para verificarmos no conjunto A : ");
            int N = int.Parse(Console.ReadLine());


            //verifica se o numero digitado existe no conjunto
            if (A.Contains(N))
            {
                Console.WriteLine("O numero existe!");

                //remove o numero do conjunto A
                A.Remove(N);

                //percorre o conjunto A e imprime na tela
                foreach ( int x in A)
                {
                    Console.WriteLine(x);
                }
            }
            else
            {
                Console.WriteLine("Numero não existe!");
            }
            Console.ReadKey();

        }
    }
}
