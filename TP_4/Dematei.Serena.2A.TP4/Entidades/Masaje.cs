using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Masaje:Servicio
    {
        private ETipoMasaje tipo;
     
        public Masaje()
        {
        
        }

        public Masaje(ETipoMasaje tipo, int cantidadMinutos) : base(cantidadMinutos)
        {
            this.tipo = tipo;
        }

        public ETipoMasaje Tipo
        {
            get { return this.tipo; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"{this.tipo}  ");

            return sb.ToString();
        }

    }
}
