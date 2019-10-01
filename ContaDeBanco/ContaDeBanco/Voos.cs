using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDeBanco
{
    class Voos
    {
        public string Empresa { get; set; }
        public int Codigo     { get; set; }

        public Voos(string empresa, int codigo)
        {
            this.Empresa = empresa;
            this.Codigo = codigo;

        }
    }
}
