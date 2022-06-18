using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace Entidades
{
    public class ClienteDAO
    {

        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        /// <summary>
        /// Establece el string de conexion a la base de datos Spa
        /// </summary>
        static ClienteDAO()
        {
            ClienteDAO.cadena_conexion = @"Server=.;Database=Spa;Trusted_Connection=True;";
        }

        /// <summary>
        /// Crea un objeto de tipo SqlConnection que recibe la ruta del motor de base de datos.
        /// </summary>
        public ClienteDAO()
        {
            this.conexion = new SqlConnection(ClienteDAO.cadena_conexion);
        }


        /// <summary>
        /// Lee los registros de la base de datos y los guarda en la lista de clientes
        /// </summary>
        /// <returns></returns>
        public List<Cliente> Leer()
        {

            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Clientes";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Nombre = lector.GetString(0);
                    cliente.Apellido = lector.GetString(1);
                    cliente.Telefono = lector.GetString(2);
                    cliente.Dni = lector.GetInt32(3);

                    Spa.clientes.Add(cliente);
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return Spa.clientes;
        }


        /// <summary>
        /// Guarda un cliente con todos sus atributos en una base de datos
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool GuardarCliente(Cliente cliente)
        {
            bool rta = true;
            try
            {
                string sql = "INSERT INTO Clientes (Nombre,Apellido,Telefono,Dni) VALUES(@Nombre,@Apellido,@Telefono,@Dni)";

                this.comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("Nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("Apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("Telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("Dni", cliente.Dni);

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {
                rta = false;
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;

        }


        /// <summary>
        /// Borra un cliente de la base de datos a partir de su dni
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool Borrar(Cliente cliente)
        {
            bool rta = true;
            try
            {
                this.comando = new SqlCommand();
                comando.Parameters.AddWithValue("@Dni", cliente.Dni);

                string sql = "DELETE FROM Clientes";
                sql += " WHERE Dni = @Dni";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }


        /// <summary>
        /// Modifica un registro de la base de datos
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool Modificar(Cliente cliente)
        {
            bool rta = true;
            try
            {

                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                this.comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                this.comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                this.comando.Parameters.AddWithValue("@Dni", cliente.Dni);


                string sql = "UPDATE Clientes SET Nombre=@nombre, Apellido=@Apellido, Telefono=@Telefono WHERE Dni=@Dni";
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

    }

}
