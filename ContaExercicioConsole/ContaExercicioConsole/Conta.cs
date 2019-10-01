using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaExercicioConsole
{
    class Conta
    {
        private bool Preenchido = false;
        //atributos
        public string Nome { get; set; }
        private int _nconta;
        private double _valor;

        //propriedades
        public int Nconta
        {
            get { return _nconta; }
            //problema aqui
            set
            {
                if (Preenchido)
                {

                    Console.WriteLine("Conta ja possui numero associado!");

                }
                else
                {
                    Preenchido = true;
                    _nconta = value;
                }
            }

        }

        //construtores
        public void Valor(double valor)
        {
            _valor = valor;
        }

        public void Valor()
        {
            _valor = 0;
        }

        //métodos
        public override string ToString()
        {
            return "Nome: " + Nome + " N°: " + Nconta + " Valor: $" + _valor;
        }

        public void Depositar(double valor)
        {
            _valor += valor;
        }

        public void Sacar(double valor)
        {
            double val = valor + 5;
            _valor -= val;
        }
    }
}
