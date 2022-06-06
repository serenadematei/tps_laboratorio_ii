using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
        public static bool ClienteYaIngresado(string dni, string apellido)
        {
            int dniInt = int.Parse(dni);
            foreach (Cliente item in Spa.clientes)
            {
                if (item.Dni == dniInt && item.Apellido == apellido)
                {
                    return true;
                }
            }
            return false;

        }

        public static bool DniYaIngresado(string dni)
        {
            int dniInt = int.Parse(dni);
            foreach (Cliente item in Spa.clientes)
            {
                if (item.Dni == dniInt)
                {
                    return true;
                }
            }
            return false;

        }

        public static bool TelefonoYaIngresado(string telefono)
        {
            foreach (Cliente item in Spa.clientes)
            {
                if (item.Telefono == telefono)
                {
                    return true;
                }
            }
            return false;

        }

        public static bool NumericoConDiezNumeros_Telefono(string telefono)
        {
            double resultado;
            bool esNumerico = double.TryParse(telefono, out resultado);
            if (esNumerico)
            {
                if (telefono.Length == 10)
                {
                    return true;
                }    
            }

            return false;
        }

        public static bool NumericoConAlMenosSieteNumeros_Dni(string dni)
        {
            int dniInt;
            bool esNumerico = int.TryParse(dni, out dniInt);

            if (esNumerico)
            {
                int cantidadNumeros = dni.Length;
                if (cantidadNumeros >= 7)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool SoloLetrasYHastaVeinteCaracteres(string cadena)
        {

            for (int i = 0; i < cadena.Length; i++)
            {
                if (!Char.IsLetter(cadena[i]) || cadena.Length > 20)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
