using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DesactivarBoton();

    public static class TurnoExtendido
    {
        public static bool yaImprimio = false;
        public static event DesactivarBoton desactivador;

        /// <summary>
        /// Genera el ticket del turno a ser impreso. 
        /// </summary>
        /// <param name="turno"></param>
        /// <returns></returns>
        public static string ImprimirTurno(this Turno turno)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***** NAMASTÉ  SPA ******");
            sb.AppendLine($"NOMBRE:{turno.Cliente.Nombre} {turno.Cliente.Apellido}\n");
            sb.AppendLine($"FECHA:{turno.Fecha.ToShortDateString()}\n");
            sb.AppendLine($"SERVICIO:{turno.Servicio.NombreServicio}");
            sb.AppendLine($"DURACION:{turno.Servicio.CantidadMinutos} minutos\n");
            yaImprimio = true;
            InvocarDesactivador();

            return sb.ToString();
        }

        /// <summary>
        /// Invoca al evento desactivador del boton Imprimir
        /// </summary>
        public static void InvocarDesactivador()
        {
            if (yaImprimio)
            {
                desactivador.Invoke();
            }
        }

    }
}
