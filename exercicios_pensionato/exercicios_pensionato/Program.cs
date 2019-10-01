using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Estudante[] estudantes = new Estudante[n];

            for (int i = 0; i < n; i++)
            {
                estudantes[i] = new Estudante();
                estudantes[i].Nome = Console.ReadLine();
                estudantes[i].Email = Console.ReadLine();
            }

            int quartos = 0;
            
            for (int i = 0; i < n; i++)
            {
               
               quartos++;
               
                Console.WriteLine("Quarto: "+quartos.ToString()+ ", estudante "+estudantes[i].Nome+" dono do E-mail: "+estudantes[i].Email);
            }

            Console.ReadKey();

        }
    }
}
