using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PersonaDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static string cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=EjerciciosUTN;Integrated Security=True";


        static PersonaDAO()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
        }

        public static bool Insertar(Persona persona)
        {
            bool retorno = false;

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;

                comando.CommandText = "INSERT INTO Clientes_Facturacion ([codigoCliente]," +
                    "[facturacionTotal])" + " VALUES (@codCliente, @facturacion)";

                comando.Parameters.AddWithValue("@codCliente", persona.Codigo);
                comando.Parameters.AddWithValue("@facturacion", persona.MontoTotal);
                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return retorno;
        }


    }
}
