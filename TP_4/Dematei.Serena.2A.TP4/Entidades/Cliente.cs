using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string telefono;
        private int dni;


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
            sb.AppendLine($"{this.nombre}                        ");
            sb.AppendLine($"{this.apellido}                ");
            sb.AppendLine($"{this.dni}                ");
            sb.AppendLine($"{this.telefono}                ");

            return sb.ToString();
        }


        /// <summary>
        /// Muestra un string con los datos de un cliente con las etiquetas de los mismos
        /// </summary>
        /// <returns></returns>
        public string MostrarUnCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre:{this.nombre}\n");
            sb.AppendLine($"Apellido:{this.apellido}\n");
            sb.AppendLine($"Dni:{this.dni}\n");
            sb.AppendLine($"Telefono:{this.telefono}\n");

            return sb.ToString();
        }


       
    }
}
