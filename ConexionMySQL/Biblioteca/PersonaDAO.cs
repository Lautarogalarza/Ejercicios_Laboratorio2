using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class PersonaDAO
    {
        static string connectionString;
        static MySqlCommand command;
        static MySqlConnection connection;
        const string NOMBRE_TABLA = "nombre";
        const string ID_TABLA = "id";

        static PersonaDAO()
        {
            connectionString = @"Server=localhost;Database=prueba;User ID=root;Password=1234;";
            command = new MySqlCommand();
            connection = new MySqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void Guardar(string nombre)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO Persona (nombre) VALUES (@Nombre)";
                command.Parameters.AddWithValue("@Nombre", nombre);
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
                command.CommandText = $"UPDATE Persona SET nombre = @Nombre WHERE id = @ID";
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
            PersonaDTO person = null;
            connection.Open();
            string query = "SELECT * FROM persona WHERE id = @id";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        person = new PersonaDTO(reader["nombre"].ToString());

                    }
                }
            }

            return person;
        }

        public static List<PersonaDTO> Leer()
        {
            List<PersonaDTO> personas = new List<PersonaDTO>();
            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM Persona";

                using (MySqlDataReader reader = command.ExecuteReader())
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
                command.CommandText = $"DELETE FROM Persona WHERE id = @ID";
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
