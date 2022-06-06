using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ducha:Servicio
    {
        private ETipoDucha tipo;


        public Ducha()
        {

        }

        public Ducha(ETipoDucha tipo, int cantidadMinutos) : base(cantidadMinutos)
        {
            this.tipo = tipo;
        }

        public ETipoDucha Tipo
        {
            get { return this.tipo; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"{this.tipo}");

            return sb.ToString();
        }
       
    }
}
