using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivo<T>
    { 
        /// <summary>
        /// Escribe en el archivo los datos que recibe
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        bool Escribir(string nombre, T datos);


        /// <summary>
        /// Lee desde un archivo
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        T Leer(string nombre);
    }
}
