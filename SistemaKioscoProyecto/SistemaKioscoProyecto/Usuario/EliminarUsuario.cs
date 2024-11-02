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
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void Tb_IdArticuloEliminar_Click(object sender, EventArgs e)
        {
            BajaUsuarioLogica();
        }

        public void BajaUsuarioLogica()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                if (int.TryParse(Tb_IdUsuario.Text, out int idUsuario))
                {
                    datos.setearConsulta("EXEC BajaUsuarioLogica @Id_Usuario", System.Data.CommandType.Text);

                    datos.setearParametro("@Id_Usuario", idUsuario);

                    datos.ejecutarAccion();
                    MessageBox.Show("Usuario dado de baja lógicamente con éxito.");
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID de usuario válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar dar de baja el usuario: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
