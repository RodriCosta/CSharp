using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio
{
    class Funcionario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void incrementar(double salario)
        {
            Salario += salario;

        }
    }

}
