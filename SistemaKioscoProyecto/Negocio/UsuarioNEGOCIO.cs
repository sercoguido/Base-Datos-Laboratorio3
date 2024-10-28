using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using dominio;
using System.Data;

namespace Negocio
{
    public class UsuarioNegocio
    {
        

        public int VerificarEmailYContrasena(string email, string contrasenia)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=BBDD_KioscoLab3; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = "SELECT CASE " +
                                      "WHEN Email = @Email AND Contrasenia = @Contrasenia THEN 2 " +
                                      "WHEN Email = @Email THEN 1 " +
                                      "ELSE 0 " +
                                      "END " +
                                      "FROM Usuario " +
                                      "WHERE Email = @Email;";
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Contrasenia", contrasenia);
                comando.Connection = conexion;

                conexion.Open();

                object resultObj = comando.ExecuteScalar();

                if (resultObj != null)
                {
                    int result = (int)resultObj;
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

    }
}
