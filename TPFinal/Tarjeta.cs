using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    public class Tarjeta
    {
        private string iUltimosDigitos;
        private string iNombre;
        private string iTipo;

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }
        public string Tipo
        {
            get { return this.iTipo; }
            set { this.iTipo = value; }
        }
        public string UltimosDigitos
        {
            get { return this.iUltimosDigitos; }
            set { this.iUltimosDigitos = value; }
        }

        public Tarjeta(string pNombre, string pTipo, string pUltimosDigitos)
        {
            this.iNombre = pNombre;
            this.iTipo = pTipo;
            this.iUltimosDigitos = pUltimosDigitos;
        }
    }
}
