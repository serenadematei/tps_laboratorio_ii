using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string telefono;


        public Cliente(){}
        public Cliente(string nombre, string apellido, string telefono, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.dni = dni;
            
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }

        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }

        }


        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }

        }

       

        

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre:{this.nombre} {this.apellido}");
            sb.AppendLine($"Dni:{this.dni}");
            sb.AppendLine($"Telefono:{this.telefono}");

            return sb.ToString();
        }


        /// <summary>
        /// Muestra un string con los datos de un cliente sin las etiquetas de los mismos
        /// </summary>
        /// <returns></returns>
        public string MostrarUnCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre}          \n\n\n         ");
            sb.AppendLine($"{this.apellido}                  ");
            sb.AppendLine($"{this.dni}       \n\n\n          ");
            sb.AppendLine($"{this.telefono}      \n\n\n          ");

            return sb.ToString().PadRight(10);

        }


       
    }
}
