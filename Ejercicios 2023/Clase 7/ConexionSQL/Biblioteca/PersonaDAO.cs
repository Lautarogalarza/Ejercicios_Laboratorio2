using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class PersonaDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        const string NOMBRE_TABLA = "Nombre";
        const string ID_TABLA = "ID";

        static PersonaDAO()
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
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO Personas (Nombre) VALUES (@Nombre)";
                command.Parameters.AddWithValue("@Nombre",nombre);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { connection.Close(); }
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

        public static PersonaDTO Leer(int id)
        {
            PersonaDTO persona = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM Personas WHERE N = @ID";
                command.Parameters.AddWithValue ("@ID", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        persona = new PersonaDTO(reader[NOMBRE_TABLA].ToString(), Convert.ToInt32(reader[ID_TABLA]));
                    }
                }

                return persona;
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<PersonaDTO> Leer()
        {
            List<PersonaDTO> personas = new List<PersonaDTO>();
            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM Personas";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        personas.Add(new PersonaDTO(reader[NOMBRE_TABLA].ToString(), Convert.ToInt32(reader[ID_TABLA])));
                    }
                }

                return personas;
            }
            catch (Exception e)
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
                command.CommandText = $"DELETE FROM Personas WHERE ID = {id}";
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

    }
}
