using System;

namespace Banco
{
    public class Conta
    {

        public int Numero { get; set; }

        public double Saldo { get; protected set; }

        public Cliente Titular { get; internal set; }

      

        public virtual void Deposita(double ValorDepositadoConv)
        {
            this.Saldo += ValorDepositadoConv;
        }

        public virtual void Saca(double ValorDeSaqueConv)
        {
            this.Saldo -= ValorDeSaqueConv;
        }
    }

    public class ContaPoupanca : Conta
    {

        public override void Saca(double ValorDeSaqueConv)
        {
            base.Saca(ValorDeSaqueConv + 0.10);
            

        }



    }
    public class ContaCorrente : Conta
    {
        public override void Saca(double ValorDeSaqueConv)
        {

            base.Saca(ValorDeSaqueConv + 0.10);
        }
        public override void Deposita(double ValorDeSaqueConv)
        {
            base.Deposita(ValorDeSaqueConv + 0.05);


        }


    }
}