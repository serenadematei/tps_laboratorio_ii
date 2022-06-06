
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Entidades
{
    public static class Spa
    {
        
        public static List<Cliente> clientes;
       
        /// <summary>
        /// Constructor estatico de clase Spa, inicializa la lista de clientes e invoca al metodo CargarInformacion
        /// </summary>
        static Spa()
        {
            clientes = new List<Cliente>();
            CargarInformacion();
        }


        /// <summary>
        /// Lee la lista de clientes desde un archivo json
        /// </summary>
        private static void CargarInformacion()
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            string file = ruta+@"ListaDeClientes.json";
            SerializadoraJson json = new SerializadoraJson();

            if (File.Exists(file))
            {
                Spa.clientes = json.Leer("ListaDeClientes.json");
            }
            else
            {
                Spa.clientes = json.Leer("MOCK_DATA.json");  
            }

        }

        
        /// <summary>
        /// Guarda la lista de clientes con las nuevas modificaciones en un archivo json
        /// </summary>
        /// <returns></returns>
        public static bool GuardarInformacion()
        {
            SerializadoraJson json = new SerializadoraJson();
            if (json.Escribir("ListaDeClientes.json", Spa.clientes))
            {
                return true;
            }

            return false;
        }


        public static List<Cliente> Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }


        public static bool AgregarCliente(Cliente cliente)
        {

           if (cliente is not null)
           {
                clientes.Add(cliente);
                return true;
           }

            return false;
        }

        public static bool RemoverCliente(Cliente cliente)
        {

            if (cliente is not null && clientes.Contains(cliente))
            {
                clientes.Remove(cliente);
                return true;
            }

            return false;
        }


        public static int OrdenarPorApellidoAscendente(Cliente c1, Cliente c2)
        {
            return String.Compare(c1.Apellido, c2.Apellido);
        }


        public static Cliente BuscarClientePorIndice(int indice)
        {
            Cliente auxCliente = null;
            for (int i = 0; i < Spa.clientes.Count; i++)
            {
                if (i == indice)
                {
                    return Spa.clientes[i];
                }
            }

            return auxCliente;
        }
    }
}
