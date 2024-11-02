using Negocio;
using System;
using System.Windows.Forms;

namespace SistemaKioscoProyecto
{
    public partial class EliminarArticulos : Form
    {
        public EliminarArticulos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BajaArticuloLogica();
        }

        public void BajaArticuloLogica()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                if (int.TryParse(Tb_IdArticulo.Text, out int idArticulo))
                {
                    datos.setearConsulta("EXEC BajaArticuloLogica @Id_Articulo", System.Data.CommandType.Text);

                    datos.setearParametro("@Id_Articulo", idArticulo);

                    datos.ejecutarAccion();
                    MessageBox.Show("Artículo dado de baja lógicamente con éxito.");
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID de artículo válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar dar de baja el artículo: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private void EliminarArticulos_Load(object sender, EventArgs e)
        {

        }
    }
}
