using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorComoParametro
{
    class Program
    {
        static void Main(string[] args)
        {
            //metodo com params nos parametros entende que voce esta passando os valores para um vetor no argumento da chamada do metodo
            int conta = Calculator.Sum(1,2,3);
            Console.WriteLine(conta.ToString());
            Console.ReadKey();
        }
    }
}
