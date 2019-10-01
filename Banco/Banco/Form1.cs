using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial  class Banco : Form
    {
        // declaração da conta nova como atributo do formulario para que as chamadas dos metodos do formulario possam ter acesso as coisas dela metodos, variaveis.
        //private Conta c;
        //private ContaPoupanca d;
        //private ContaCorrente f;
        private Conta[] contas;

        public Banco()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  // cria uma nova conta e guarda sua referencia  no atributo  do formulario atributo "c".
           //this.c = new Conta();
           //c.Numero = 1;
           //Cliente rodrigo =new Cliente("Rodrigo");
           //c.Titular = rodrigo;

            //this.d = new ContaPoupanca();
            //d.Numero = 2;
            //Cliente fabio = new Cliente("Fabio");
            //d.Titular = fabio;

            //this.f = new ContaCorrente();
            //f.Numero = 3;
            //Cliente alexandre = new Cliente("Alexandre");
            //f.Titular = alexandre;

            //textTitular.Text = d.Titular.Nome;
            //textNumero.Text = Convert.ToString(d.Numero);
            //textSaldo.Text = (d.Saldo.ToString());

            //// criando um array
            ////int[] numeros = new int[5];

            ////numeros[0] = 1;
            ////numeros[1] = 2;
            ////numeros[2] = 3;
            ////numeros[3] = 4;
            ////numeros[4] = 5;

            ////MessageBox.Show("numero"+numeros[0]);

            //Conta[] contas = new Conta[6];

            //contas[0] = new Conta();
            //contas[0].Numero = 4;
            //Cliente Sarah = new Cliente("Sarah");
            //contas[0].Titular = Sarah;


            //criando o array para armazenar as contas
            contas = new Conta[3];

            //vamos inicializar algumas instancias de contas
            this.contas[0] = new Conta();
            this.contas[0].Titular = new Cliente("Rodrigo");
            this.contas[0].Numero = 1;

            this.contas[1] = new Conta();
            this.contas[1].Titular = new Cliente("Maria");
            this.contas[1].Numero = 2;

            this.contas[2] = new Conta();
            this.contas[2].Titular = new Cliente("Ricardo");
            this.contas[2].Numero = 3;
            

           



        }

        private void Deposita_Click(object sender, EventArgs e)
        {
           int indice = Convert.ToInt32(textIndice.Text);
           Conta Selecionada = this.contas[indice];
           string ValorDepositado = textValor.Text;
           double ValorDepositadoConv = Convert.ToDouble(ValorDepositado);
           Selecionada.Deposita(ValorDepositadoConv);
           textSaldo.Text = Convert.ToString(Selecionada.Saldo);
           MessageBox.Show("Depositou "+ValorDepositado);

        }

        private void buttonSaca_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(textIndice.Text);
            Conta Selecionada = this.contas[indice];
            string ValorDeSaque = textSaca.Text;
            double ValorDeSaqueConv = Convert.ToDouble(ValorDeSaque);
            Selecionada.Saca(ValorDeSaqueConv);
            textSaldo.Text = Convert.ToString(Selecionada.Saldo);
            MessageBox.Show("Sacou "+ValorDeSaque);
        }

        private void textIndice_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(textIndice.Text);
            //converte o numero digitado no campo para int e o retorna numa variavel.
            Conta Selecionada = this.contas[indice];
            //chama a conta instanciada e passa a variavel com o numero digitado no array.
            textNumero.Text = Convert.ToString(Selecionada.Numero);
            //passa o numero de dentro da instancia selecionada que esta dendro da variavel para o campo convertendo em string.
            textTitular.Text = Selecionada.Titular.Nome;
            textSaldo.Text = Convert.ToString(Selecionada.Saldo);
            


        
        }
    }
}
