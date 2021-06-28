using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61.Entidades
{
    public static class PersonaDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static PersonaDao()
        {
            cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=EjerciciosUTN;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }


        public static void Guardar(Persona persona)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO Persona (Nombre, Apellido) VALUES (@nombre, @apellido)";
                comando.Parameters.AddWithValue("@nombre", persona.Nombre);
                comando.Parameters.AddWithValue("@apellido", persona.Apellido);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static Persona LeerPorId(int id)
        {
            Persona persona = null;
            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM Persona WHERE ID = {id}";
                SqlDataReader dataReader = comando.ExecuteReader();

                if (dataReader.Read())
                {
                    persona = new Persona(Convert.ToInt32(dataReader["ID"]), dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString());
                }

                dataReader.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return persona;
        }


        public static List<Persona> Leer()
        {
            List<Persona> persona = new List<Persona>();
            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM Persona";
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    persona.Add(new Persona(Convert.ToInt32(dataReader["ID"]), dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString()));
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return persona;
        }


        public static void Eliminar(int id)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE FROM Persona WHERE ID ={id}";
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Modificar(Persona persona)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE Persona SET Nombre = @nombre, Apellido = @apellido WHERE ID = {persona.Id}";
                comando.Parameters.AddWithValue("@apellido", persona.Apellido);
                comando.Parameters.AddWithValue("@nombre", persona.Nombre);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }


    }
}
