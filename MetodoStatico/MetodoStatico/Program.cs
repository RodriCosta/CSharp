using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MetodoStatico
{
    class Program
    {
        static double PI = 3.14; 

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double circ = Circunferenncia(raio);
            double vol = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Valor de PI: " + PI.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }

        static double Volume(double r)
        {

            return 4.0 / 3.0 * PI * r * r * r;

        }

        static double Circunferenncia(double r)
        {
            return 2.0 * PI * r;
        }
    }
}
