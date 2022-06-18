
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

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
        /// Obtiene los clientes desde la lectura de una base de datos
        /// </summary>
        private static void CargarInformacion()
        {
            ClienteDAO dao = new ClienteDAO();
            Spa.clientes = dao.Leer();
        }

        /// <summary>
        /// Guarda los clientes que se encuentran actualmente en la lista en un archivo.json
        /// </summary>
        /// <returns></returns>
        public static bool GuardarClientesEnArchivoJson()
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


        /// <summary>
        /// Asegura la existencia de un cliente al buscarlo por su dni en la lista de clientes
        /// </summary>
        /// <param name="unCliente"></param>
        /// <param name="MostrarClienteEncontrado"></param>
        /// <returns></returns>
        public static Cliente BuscarClientePorDni(Cliente unCliente,Action MostrarClienteEncontrado)
        {
            
            foreach (Cliente item in Spa.clientes)
            {
                if (item.Dni == unCliente.Dni)
                {
                    MostrarClienteEncontrado();
                }
            }

            return unCliente;
        }



        /// <summary>
        /// Desde un hilo secundario, obtiene la cantidad actual de clientes en la lista, sin interrumpir el hilo principal
        /// </summary>
        /// <returns></returns>
        public static async Task<string> ContarTodosLosRegistros()
        {

            string datos = await Task.Run(() =>
            {
                Thread.Sleep(2000);
                int cantidad = Spa.clientes.Count;
                return $"La cantidad de registros es {cantidad}";
            });

            if (datos.Length < 0)
            {
                return "No hay registros que contar";
            }

            return datos;
        }

    }
}
