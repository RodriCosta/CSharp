using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListaExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o numero de funcionários: ");
            int funcionarios = int.Parse(Console.ReadLine());

       
            List<Funcionario> func = new List<Funcionario>();

            int id = 0;

            for (int i = 0; i < funcionarios; i++)
            {
                id++;
                Console.WriteLine("Digite o nome do Funcionário: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o salário do mesmo: ");
                double salario = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture );

                func.Add(new Funcionario(id,nome,salario));
            }
            foreach (var item in func)
            {
                Console.WriteLine("Funcionários");
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Salario);
            }
            Console.WriteLine("Qual Funcionário você gostaria de aumentar o salário? ");

            int idProcurado = int.Parse(Console.ReadLine());

            Funcionario fun = func.Find(x => x.Id == idProcurado);
            if(fun != null)
            {
                Console.Write("entre com a porcentagem: ");
                double porcento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fun.incrementar(porcento);
            }
            else
            {
                Console.WriteLine("isso nao existe!");
            }

            foreach (var item in func)
            {
                Console.WriteLine("Funcionários");
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Salario);
            }
            Console.ReadKey();


        }
    }
}
