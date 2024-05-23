using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PersonaAccesoDatos
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static PersonaAccesoDatos()
        {
            connectionString = @"Data Source=.;Initial Catalog=Ejercicios_UTN;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }


        public static void Guardar(string nombre)
        {
            try
            {   command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO Personas (Nombre) VALUES (@Nombre)";
                command.Parameters.AddWithValue("@Nombre", nombre);

                int rows = command.ExecuteNonQuery();

             }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static Persona Leer(int id)
        {
            Persona persona = null;


            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM Personas WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        persona = new Persona(dataReader["Nombre"].ToString(), Convert.ToInt32(dataReader["ID"]));
                    }
                }

                return persona;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }


        public static void Modificar(string nuevoNombre, int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE Personas SET Nombre = @Nombre WHERE ID = @ID";
                command.Parameters.AddWithValue("@Nombre", nuevoNombre);
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Eliminar(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM Personas WHERE ID ={id}";
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }


        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Personas";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        personas.Add(new Persona(dataReader["Nombre"].ToString(), Convert.ToInt32(dataReader["ID"])));
                    }
                }

                return personas;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
