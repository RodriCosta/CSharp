using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "João", "Bob" };

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("------------");

            foreach(string apelidoDaCasaDoArray in vect)
            {
                Console.WriteLine(apelidoDaCasaDoArray);
            }

            Console.ReadKey();
        }
    }
}
