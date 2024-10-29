using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {





































        ///ESTO POR OTRO LADO -----------------------------------------
        public bool PuedeRestarStock(int idArticulo, int cantidad)
        {
            AccesoDatos datos = new AccesoDatos();
            int stockActual = 0;

            try
            {
                // Consulta SQL para obtener el stock actual del artículo.
                datos.setearConsulta("SELECT Stock FROM Articulo WHERE Id_Articulo = @IdArticulo");
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.ejecutarLectura();

                // Si encuentra el artículo, obtiene el stock actual.
                if (datos.Lector.Read())
                {
                    stockActual = Convert.ToInt32(datos.Lector["Stock"]);
                }
                else
                {
                    throw new Exception("El artículo no existe.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            // Verificar si el stock actual permite restar la cantidad solicitada.
            return stockActual >= cantidad;
        }

        public decimal ObtenerPrecioArticulo(int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            decimal precio = 0;

            try
            {
                datos.setearConsulta("SELECT Precio FROM Articulo WHERE Id_Articulo = @IdArticulo");
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    precio = Convert.ToDecimal(datos.Lector["Precio"]);
                }
            }
            catch (Exception ex)
            {
                throw ex; // Manejo de errores
            }
            finally
            {
                datos.cerrarConexion();
            }

            return precio;
        }

        public string ObtenerNombreArticulo(int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            string nombreArticulo = string.Empty;

            try
            {
                datos.setearConsulta("SELECT Nombre FROM Articulo WHERE Id_Articulo = @IdArticulo");
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    nombreArticulo = datos.Lector["Nombre"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex; // Manejo de errores
            }
            finally
            {
                datos.cerrarConexion();
            }

            return nombreArticulo;
        }




    }
}