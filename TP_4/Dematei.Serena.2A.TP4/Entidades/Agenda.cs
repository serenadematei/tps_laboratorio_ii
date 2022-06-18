using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class Agenda
    {
        private static List<Turno> turnos;
        
        /// <summary>
        /// Constructor estatico de la clase Agenda, inicializa la lista de turnos e invoca al metodo CargarInformacionTurnos
        /// </summary>
        static Agenda()
        {
            Agenda.turnos = new List<Turno>();
            CargarInformacionTurnos();
        }

        public static List<Turno> Turnos
        {
            get { return turnos; }
            set { Turnos = value; }
        }


        /// <summary>
        /// Lee la lista de turnos desde un archivo xml
        /// </summary>
        public static void CargarInformacionTurnos()
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            string file = ruta + @"ListaDeTurnos.xml";
            SerializadoraXml xml = new SerializadoraXml();

            if (File.Exists(file))
            {
                Agenda.turnos = xml.Leer("ListaDeTurnos.xml");
            }
        }

     
        /// <summary>
        /// Guarda la lista de turnos con las nuevas modificaciones en el archivo xml
        /// </summary>
        /// <returns></returns>
        public static bool GuardarInformacion()
        {
            SerializadoraXml xml = new SerializadoraXml();
            if (xml.Escribir("ListaDeTurnos.xml", Agenda.turnos))
            {
                return true;
            }

            return false;
        }

        public static bool AgendarNuevoTurno(Turno unTurno)
        {
            if (unTurno is not null)
            {
                turnos.Add(unTurno);
                return true;
            }
            return false;

        }

        public static bool CancelarTurno(Turno turno)
        {
            if (turno is not null && turnos.Contains(turno))
            {
                turnos.Remove(turno);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Recorre la lista de turnos en busca de aquel que se encuentre en el mismo indice que recibe por parametro
        /// </summary>
        /// <param name="indice"></param>
        /// <returns></returns>
        public static Turno BuscarTurnoPorIndice(int indice)
        {
            Turno auxTurno = null;
            for (int i = 0; i < Agenda.Turnos.Count; i++)
            {
                if (i == indice)
                {
                    return Agenda.Turnos[i];
                }
            }

            return auxTurno;

        }

        public static int OrdenarPorApellidoAscendente(Turno t1, Turno t2)
        {
            return String.Compare(t1.Cliente.Apellido, t2.Cliente.Apellido);
        }

        public static int OrdenarPorFechaAscendente(Turno t1, Turno t2)
        {
            int retorno = 0;
            if (t1.Fecha > t2.Fecha)
            {
                retorno = 1;
            }
            if (t1.Fecha < t2.Fecha)
            {
                retorno = -1;
            }

            return retorno;
        }

    }
}
