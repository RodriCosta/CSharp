using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
           

            ////conta todas as casas vezes as colunas
            //Console.WriteLine(mat.Length);

            ////numero de linhas
            //Console.WriteLine(mat.Rank);

            ////Primeira diimensao(linahs da matriz)
            //Console.WriteLine(mat.GetLength(0));

            ////segunda dimensao(colunas da matriz)
            //Console.WriteLine(mat.GetLength(1));


            Console.WriteLine("Informe o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("linha : "+ i.ToString());
                for (int j = 0; j < n; j++)
                {

                    mat[i,j] = int.Parse(Console.ReadLine());


                }

            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Main Diagonal: "+ mat[i,i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {

                for(int j = 0; j < n; j++)
                {


                    if(mat[i,j] < 0)
                    {
                        Console.WriteLine( mat[i,j] + " é negativo!");
                    }

                }

            }
            Console.ReadKey();
        }
    }
}
