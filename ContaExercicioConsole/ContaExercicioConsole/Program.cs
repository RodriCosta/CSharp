using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaExercicioConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta C = new Conta();
            Console.WriteLine("Entre com o nome do individuo: ");
            C.Nome = Console.ReadLine();
            Console.WriteLine("Entre com o numero de sua conta: ");
            C.Nconta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Voce deseja inserir um deposito inicial (s/n): ");
            string resp = Console.ReadLine();
            if (resp == "s")
            {
                Console.WriteLine("Digite o Valor a ser depositado: ");
                double val = Convert.ToDouble(Console.ReadLine());
                C.Valor(val);
            }
            else if (resp == "n")
            {
                C.Valor();
            }
            Console.WriteLine(C.ToString());
            Console.WriteLine("Deseja alterar o seu nome?");
            string aut = Console.ReadLine();
            if (aut == "s")
            {
                Console.WriteLine("Digite o novo nome: ");
                string nome = Console.ReadLine();
                C.Nome = nome;
                Console.WriteLine(C.ToString());
            }
            else if (aut == "n")
            {
                Console.WriteLine("Okay...");
            }
            Console.WriteLine("Digite o Valor a ser depositado: ");
            double valDep = Convert.ToDouble(Console.ReadLine());
            C.Depositar(valDep);
            Console.WriteLine(C.ToString());

            Console.WriteLine("Digite o Valor a ser sacado: ");
            double valSac = Convert.ToDouble(Console.ReadLine());
            C.Sacar(valSac);
            Console.WriteLine(C.ToString());
            Console.ReadKey();
        }
    }
}
