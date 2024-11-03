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
    public partial class AgregarMarca : Form
    {
        public AgregarMarca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarMarcas();
        }

        public void AgregarMarcas()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("EXEC AltaMarca @NombreMarca", System.Data.CommandType.Text);

                datos.setearParametro("@NombreMarca", Tb_NombreMarca.Text.Trim()); // Asegúrate de usar el TextBox correcto

                datos.ejecutarAccion();
                MessageBox.Show("Marca agregada con éxito.");
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
