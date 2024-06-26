using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LogDAO
    {
        private SqlConnection sqlConnection;

        public LogDAO()
        {
            sqlConnection = new SqlConnection("Server=.;Database=bomberos-db;Trusted_Connection=True;");
        }

        public void InsertarLog(string mensaje)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO dbo.log (entrada, alumno) VALUES (@mensaje, 'Lautaro Galarza')", sqlConnection);
                command.Parameters.AddWithValue("@mensaje", mensaje);
                command.ExecuteNonQuery();
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public string LeerLog()
        {
            try
            {   
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("SELECT entrada FROM dbo.log", sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                StringBuilder sb = new();

                if (reader.Read())
                {
                    sb.AppendLine(reader["entrada"].ToString());
                }

                return sb.ToString();
            }
            finally
            {

               sqlConnection.Close();
            }
        }
    }
}
