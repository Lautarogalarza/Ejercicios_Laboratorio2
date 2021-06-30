using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AccesoDB : ILogs
    {

        private SqlConnection connection;
        private SqlCommand command;
        private static string connectionString = @" Server = .\SQLEXPRESS ; Database = 20201203-sp ; Trusted_Connection = true ; ";
        public bool Guardar()
        {
            bool retorno = false;
            try
            {
                command = new SqlCommand();
                connection = new SqlConnection(connectionString);
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                command.CommandText = "INSERT INTO log (entrada,alumno) VALUES (@entrada,@alumno);";
                command.Parameters.AddWithValue("@entrada", $"Se disfrutó el gol del siglo a las {DateTime.Now.ToString("dd/mm/yyyyy")} hs");
                command.Parameters.AddWithValue("@alumno", "Lautaro Galarza");

                connection.Open();
                command.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return retorno;
        }

        public string Leer()
        {
            try
            {
                string logs= string.Empty;

                command = new SqlCommand();
                connection = new SqlConnection(connectionString);
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                command.CommandText = "SELECT entrada,alumno FROM log;";
                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {

                    logs += $"{dataReader["entrada"].ToString()} Alumno: {dataReader["alumno"].ToString()}";
                }
                return logs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
