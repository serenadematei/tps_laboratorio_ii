using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {
        private DateTime fecha;
        private Cliente cliente;
        private Servicio servicio;
        private int codigo;

        public Turno(){}

        public Turno(DateTime fecha, Cliente cliente,Servicio servicio)
        {
            this.fecha = fecha;
            this.cliente = cliente;
            this.servicio = servicio;
        }

        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }

        }

        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public Servicio Servicio
        {
            get { return this.servicio; }
            set { this.servicio = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha:{this.fecha.ToShortDateString()}          \n");
            sb.AppendLine($"Cliente:{this.cliente.ToString()}          \n"); 
            sb.AppendLine($"Servicio:{this.servicio.ToString()}");


            return sb.ToString();
        }

        /// <summary>
        /// Retorna una cadena con los datos esenciales para realizar el ticket de turno
        /// </summary>
        /// <returns></returns>
        public string ImprimirTurno()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***** NAMASTÉ  SPA ******");
            sb.AppendLine($"NOMBRE:{this.Cliente.Nombre} {this.Cliente.Apellido}\n");
            sb.AppendLine($"FECHA:{this.fecha.ToShortDateString()}\n");
            sb.AppendLine($"SERVICIO:{this.Servicio.NombreServicio}");
            sb.AppendLine($"DURACION:{this.Servicio.CantidadMinutos} minutos\n");


            return sb.ToString();
        }


        /// <summary>
        /// Muestra un string con los datos de un turno sin incluir las etiquetas de los mismos
        /// </summary>
        /// <returns></returns>
        public string MostrarUnTurno()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.fecha.ToShortDateString()}                 \n");
            sb.AppendLine($"{this.cliente.Nombre}          \n"); 
            sb.AppendLine($"{this.cliente.Apellido}          \n");
            sb.AppendLine($"{this.cliente.Dni}          \n");
            sb.AppendLine($"{this.cliente.Telefono}          \n");
            sb.AppendLine($"{this.servicio.ToString()}          \n");
           
            return sb.ToString();
        }

    }
}
