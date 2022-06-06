using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{

    [XmlInclude(typeof(Masaje))]
    [XmlInclude(typeof(Ducha))]
    [XmlInclude(typeof(Holistica))]
    public class Servicio
    {
        
        private int cantidadMinutos;

        public Servicio()
        { 
        
        }
        
        public string NombreServicio
        {
            get { return this.GetType().Name; }
        }

        public Servicio(int cantidadMinutos)
        {
          
            this.CantidadMinutos = cantidadMinutos;
        }

        public int CantidadMinutos { get => cantidadMinutos; set => cantidadMinutos = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"{this.cantidadMinutos}          \n\n");
            sb.AppendLine($"{this.GetType().Name}            \n\n");

            return sb.ToString();
        }


        /// <summary>
        /// Muestra un string con los datos de un servicio sin las etiquetas de los mismos
        /// </summary>
        /// <returns></returns>
        public virtual string MostrarUnServicio()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}         ");
            sb.AppendLine($"{this.cantidadMinutos}");
         
            return sb.ToString();
        }
    }
}
