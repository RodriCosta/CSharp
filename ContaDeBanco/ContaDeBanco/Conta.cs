using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDeBanco
{
    class Conta
    {

        private Cliente Titular;
        public double saldo { get; private set; }
        public int Numero { get; set; }

       // maneira manual de declarar propriedades de atributos.
        //{
        //    get
        //    {
        //        return _numero;

        //    }

        //    set
        //    {
        //        _numero = value;
        //    }
        //}
        
        



        public void Deposita (double valor)
        {
            this.saldo += valor;


        }

        public string Saca (double valor)
        {
          this.saldo -= valor;
            
            if (this.saldo < valor)
            {
                return "Voce nao tem dinheiro"; 
               
            }
            return "valor sacado";
            
        }
        public void Transfere(double valor, Conta destino)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                destino.saldo += valor;


            }
        }

        ////escrevendo no atributo sem a propiedade
        //public void Escreve(int novonum)
        //{

        //    this.numero = novonum;
        //}
        ////retorna o valor do atributo sem a propriedade
        //public double PegaSaldo()
        //{
        //    //o this.saldo pede pra ele retornar o saldo referente a instancia da classe que o chama.
        //    return this.saldo;

        //}

    }

    public class Cliente
    {
        public string nome;
        public string rg;
        public string cpf;
        public string endereco;
    }


}
