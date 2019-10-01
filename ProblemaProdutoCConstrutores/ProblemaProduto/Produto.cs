using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProblemaProduto
{
    class Produto
    {
        //atributos com auto properties
        public string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //construtores
        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;

        }

        ////Properties com logica customizadas
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //METODOS
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionaProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;

        }

        public void RemoveProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;

        }

        public override string ToString()
        {
            return Nome + ", Preço $ " +
            Preco.ToString("F2", CultureInfo.InvariantCulture) + " " +
            Quantidade + "Unidades, Total $ " +
            ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        //public double Preco
        //{
        //    get { return _preco; }
        //    set { }
        //}

        //public int Quantidade
        //{
        //    get { return _quantidade; }
        //}

        ////Encapsulamento Manual
        //public string GetNome()
        //{
        //    return _nome;
        //}
        //public void SetNome(string nome)
        //{
        //    if (nome != null && nome.Length > 1) {
        //        _nome = nome;
        //    }
        //}
        //public double GetPreco()
        //{
        //    return _preco;
        //}
        //public int GetQuantidade() {
        //    return _quantidade;
        //        }





    }
}
