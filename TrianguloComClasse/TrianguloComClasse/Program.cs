using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TrianguloComClasse
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo X, Y;
            X = new Triangulo();
            Y = new Triangulo();
           
            Console.WriteLine("Entre com as medidas do triângulo X:");
            X.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            Y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = X.CalculaArea();
            double areaY = Y.CalculaArea();

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X ");
            }
            else
            {
                Console.WriteLine("Maior área: Y ");
            }
            Console.ReadKey();
        }
    }
}
