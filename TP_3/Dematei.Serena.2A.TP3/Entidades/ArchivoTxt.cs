using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class ArchivoTxt : IArchivo<string>
    {
        public bool Escribir(string ruta, string datos)
        {
            bool seGuardo = false;
            try
            {
                using (StreamWriter writer = new StreamWriter(ruta))
                {
                    if (!File.Exists(ruta))
                    {
                        File.Create(ruta);
                    }

                    writer.WriteLine(datos.ToString());
                    seGuardo = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivoException("Ocurrio un problema al guardar en archivo txt", e);
            }

            return seGuardo;
        }

        public string Leer(string ruta)
        {
            string retorno = string.Empty;
            try
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    retorno = streamReader.ReadToEnd();
                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw new ArchivoException("Ocurrio un problema al leer del archivo txt ", e);
            }

            
        }
    }
}
