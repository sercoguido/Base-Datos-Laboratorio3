using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaKioscoProyecto
{
    public partial class InformeMarcas : Form
    {
        public InformeMarcas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObtenerResumenArticulosPorMarca();
        }

        public void ObtenerResumenArticulosPorMarca()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("EXEC sp_ResumenArticulosPorMarca @IdMarca", System.Data.CommandType.Text);
                datos.setearParametro("@IdMarca", Convert.ToInt32(Tb_IDMarca.Text.Trim()));

                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    // Obtenemos la cantidad de artículos y el precio promedio
                    int cantidadArticulos = datos.Lector.GetInt32(0);   
                    decimal precioPromedio = datos.Lector.GetDecimal(1);

                    Lbl_Cantidad.Text = cantidadArticulos.ToString();
                    Lbl_Promedio.Text = precioPromedio.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron artículos para esta marca.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
