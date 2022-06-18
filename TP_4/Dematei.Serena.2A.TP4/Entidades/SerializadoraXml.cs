using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializadoraXml : IArchivo<List<Turno>>
    {

        static string rutaBase;

        static SerializadoraXml()
        {
            rutaBase = AppDomain.CurrentDomain.BaseDirectory;
        }

        public bool Escribir(string nombre, List<Turno> datos)
        {
            bool GuardadoConExito;
            string nombreArchivo = rutaBase + nombre;
            try
            {
                if (!Directory.Exists(rutaBase))
                {
                    Directory.CreateDirectory(rutaBase);
                }

                using (StreamWriter streamWriter = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Turno>));
                    xmlSerializer.Serialize(streamWriter, datos);
                }
                GuardadoConExito = true;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {rutaBase}", e);
            }

            return GuardadoConExito;
        }

        public List<Turno> Leer(string nombre)
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            List<Turno> datos = default;
            try
            {

                if (Directory.Exists(rutaBase))
                {
                    
                    string[] archivosEnElPath = Directory.GetFiles(rutaBase);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains(nombre))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {

                        using (StreamReader sr = new StreamReader(archivo))
                        {

                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Turno>));
                            datos = (List<Turno>)xmlSerializer.Deserialize(sr);

                        }
                    }
                }

                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {rutaBase}", e);
            }

        }
    }
}

