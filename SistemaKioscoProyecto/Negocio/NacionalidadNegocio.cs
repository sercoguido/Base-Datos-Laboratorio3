using dominio;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NacionalidadNegocio
    {
        public List<Nacionalidad> listar()
        {
            List<Nacionalidad> lista = new List<Nacionalidad>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select id_Nacionalidad,NombreNacionalidad from Nacionalidad");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Nacionalidad aux = new Nacionalidad();
                    aux.IdNacionalidad = (int)datos.Lector["id_Nacionalidad"];
                    aux.Nombre = (string)datos.Lector["NombreNacionalidad"];

                    lista.Add(aux);
                }
                datos.cerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Agregar(Nacionalidad nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into Nacionalidad (NombreNacionalidad) values (@NombreNacionalidad)");
                datos.setearParametro("@NombreNacionalidad", nuevo.Nombre);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Modificar(Nacionalidad modificar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE Nacionalidad set NombreNacionalidad=@NombreNacionalidad where id_nacionalidad=@id");
                datos.setearParametro("@NombreNacionalidad", modificar.Nombre);
                datos.setearParametro("@id", modificar.IdNacionalidad);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("DELETE Nacionalidad where id_nacionalidad=@id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
