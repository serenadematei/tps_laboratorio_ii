using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Entidades
{
    public class SerializadoraJson : IArchivo<List<Cliente>>
    {

        static string rutaBase;

        public SerializadoraJson()
        {
            rutaBase = AppDomain.CurrentDomain.BaseDirectory;
        }

        public bool Escribir(string nombre, List<Cliente> datos)
        {
            bool GuardadoConExito;
            string nombreArchivo = rutaBase + nombre;

            try
            {
                if (!Directory.Exists(rutaBase))
                {
                    Directory.CreateDirectory(rutaBase);
                }


                File.WriteAllText(nombreArchivo, JsonSerializer.Serialize(datos));
                GuardadoConExito = true;

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {rutaBase}", e);
            }

            return GuardadoConExito;
        }

        public List<Cliente> Leer(string nombre)
        {
            string archivo = string.Empty;
            List<Cliente> datosRecuperados = default;
            string nuevoPath = rutaBase + nombre;

           
            try
            {
               
                if (Directory.Exists(rutaBase))
                {
                    
                    string[] archivosEnElPath = Directory.GetFiles(rutaBase);
                    foreach (string archivoInterno in archivosEnElPath)
                    {
                        if (archivoInterno.Contains(nombre)) 
                        {
                            archivo = nuevoPath; 
                            break;
                        }
                    }

                    if (archivo != null)
                    {

                        datosRecuperados = JsonSerializer.Deserialize<List<Cliente>>(File.ReadAllText(archivo));
                    }

                }

                return datosRecuperados;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {rutaBase}", e);
            }
        }
    }   
}
