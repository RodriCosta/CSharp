using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vetorespt2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] Vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Vect[i] = new Product();
                Vect[i].Name = Console.ReadLine();
                Vect[i].Price = double.Parse(Console.ReadLine());
            }

            double sum = 0.0;
            for(int i =0; i<n; i++)
            {

                sum += Vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine("Preço médio : "+ avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
