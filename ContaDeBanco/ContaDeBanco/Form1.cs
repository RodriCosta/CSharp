using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaDeBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   Cliente c = new Cliente();
            c.nome = "Rodrigo";
    

            Cliente Fabio = new Cliente();
            Fabio.nome = "Fabio";


            Cliente Adriano = new Cliente();
            Adriano.nome = "Adriano";
            
           

            Conta ContaRodrigo = new Conta();
            //escrevendo informações no atributo encapsulado pelo set
            ContaRodrigo.Deposita(100);
            //Retornando as mesmas infpormações pélo get
            MessageBox.Show(ContaRodrigo.saldo.ToString());
            ContaRodrigo.Saca(50);
            MessageBox.Show("Seu Saldo Atual é de "+ContaRodrigo.saldo.ToString()+" Bolsonaros");
           

            

            

           

//instancias da classe conta com inserção de valores nos atributos sem estarem encapsulados.
            //Conta ContaFabio = new Conta();
            //ContaFabio.saldo = 1000.0;
            //ContaFabio.titular = Fabio;
            //ContaFabio.numero = 002;
            //ContaFabio.Transfere(100,ContaRodrigo);
            //MessageBox.Show(ContaFabio.saldo.ToString());



            //Conta ContaAdriano = new Conta();
            //ContaAdriano.saldo = 1000.0;
            //ContaAdriano.titular = Adriano;
            //ContaAdriano.numero = 003;
          

            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Voos c = new Voos("Gol",0009);
            MessageBox.Show("A empresa do seu voo é " + c.Empresa + " e o seu Código é : " + c.Codigo);


        }
    }
}
