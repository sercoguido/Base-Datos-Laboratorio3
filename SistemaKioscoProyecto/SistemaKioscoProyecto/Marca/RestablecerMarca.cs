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
    public partial class RestablecerMarca : Form
    {
        public RestablecerMarca()
        {
            InitializeComponent();
        }

        private void Btn_Restablecer_Click(object sender, EventArgs e)
        {
            RestablecerMarcas();
        }
        public void RestablecerMarcas()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("EXEC RestablecerMarca @IdMarca", System.Data.CommandType.Text);

                datos.setearParametro("@IdMarca", Convert.ToInt32(Tb_IDMarca.Text.Trim()));
                datos.ejecutarAccion();
                MessageBox.Show("Marca restablecida con éxito.");
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
