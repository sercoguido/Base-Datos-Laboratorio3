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

namespace SistemaKioscoProyecto.Marca
{
    public partial class EliminarMarca : Form
    {
        public EliminarMarca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EliminarMarcas();
        }
        public void EliminarMarcas()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("EXEC BajaMarcaLogica @IdMarca", System.Data.CommandType.Text);

                datos.setearParametro("@IdMarca", Convert.ToInt32(Tb_EliminarMarca.Text.Trim())); // Asegúrate de usar el TextBox correcto

                datos.ejecutarAccion();
                MessageBox.Show("Marca eliminada con éxito.");
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
