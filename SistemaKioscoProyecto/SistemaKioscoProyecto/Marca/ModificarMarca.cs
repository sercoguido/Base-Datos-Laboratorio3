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
    public partial class ModificarMarca : Form
    {
        public ModificarMarca()
        {
            InitializeComponent();
        }

        private void Btn_ModificarMarca_Click(object sender, EventArgs e)
        {
            ModificarMarcas();
        }
        public void ModificarMarcas()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("EXEC ModificarMarca @IdMarca, @NombreMarca", System.Data.CommandType.Text);

                datos.setearParametro("@IdMarca", Convert.ToInt32(Tb_ID.Text.Trim())); 
                datos.setearParametro("@NombreMarca", Tb_Nombre.Text.Trim()); 

                datos.ejecutarAccion();
                MessageBox.Show("Marca modificada con éxito.");
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
