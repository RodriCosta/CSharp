using System;

namespace RefeOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //REF Utiliza a variavel do proprio escopo dentro do metodo por referencia e a atualiza declarando ref la e aqui.(precisa declarar o valor da variavel pois vai ser usado no metodo para se atualizar aqui).
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a.ToString());

            //Declara uma variável de saida com out na chamada dos parametros do método, essa saida vira uma referencia da variavel desse escopo la no método.
            //(Não precisa declarar o valor da variavel pois ela recebe a saida do metodo)
            int b = 10;
            int Doubl;
            Calculator.Doub(b, out Doubl);
            Console.WriteLine(Doubl.ToString());
            Console.ReadKey();
        }
    }
}
