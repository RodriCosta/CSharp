using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            //pega o valor de x, caso ele não exista ele pega o valor padrão do tipo valor
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //diz se dentro da variavel x existe ou não o valor retorna um true ou false
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //retorna um erro se voce tenta pegar o valor de um tipo valor nullable
            if (x.HasValue) { Console.WriteLine(x.Value); } else { Console.WriteLine("X é null !"); }
            if (y.HasValue) { Console.WriteLine(y.Value); } else { Console.WriteLine("Y é null !"); }

            //vou jogar em z o valor de x, caso o x seja nullable ele atribui outro valor atravez do comando "??"
            double z = x ?? 5;
            Console.WriteLine(z);

            Console.ReadKey();

        }
    }
}
