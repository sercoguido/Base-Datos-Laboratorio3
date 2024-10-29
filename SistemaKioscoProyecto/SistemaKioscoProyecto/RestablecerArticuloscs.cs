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
    public partial class RestablecerArticuloscs : Form
    {
        public RestablecerArticuloscs()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Tb_IdArticuloEliminar_Click(object sender, EventArgs e)
        {
            RestablecerArticulo();
        }
        public void RestablecerArticulo()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                if (int.TryParse(Tb_IdArticulo.Text, out int idArticulo))
                {
                    datos.setearConsulta("EXEC RestablecerArticulo @Id_Articulo", System.Data.CommandType.Text);

                    datos.setearParametro("@Id_Articulo", idArticulo);
                    datos.ejecutarAccion();
                    MessageBox.Show("Artículo restablecido con éxito.");
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID de artículo válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar restablecer el artículo: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
