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
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificarUsuarios();
        }
        public void ModificarUsuarios()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("EXEC ModificarUsuario @Id_Usuario, @Contrasenia, @Nombre, @Apellido, @Email, @FechaNacimiento, @FechaIngreso, @Dni, @Id_Nacionalidad, @Id_Genero", System.Data.CommandType.Text);

                datos.setearParametro("@Id_Usuario", Convert.ToInt32(Tb_IdUsuario.Text));
                datos.setearParametro("@Contrasenia", Tb_Contrasenia.Text); 
                datos.setearParametro("@Nombre", Tb_Nombre.Text);
                datos.setearParametro("@Apellido", Tb_Apellido.Text);
                datos.setearParametro("@Email", Tb_Email.Text);
                datos.setearParametro("@FechaNacimiento", Convert.ToDateTime(DTP_FechaNacimiento.Text));
                datos.setearParametro("@FechaIngreso", Convert.ToDateTime(DTP_FechaIngreso.Text));
                datos.setearParametro("@Dni", Tb_Dni.Text);
                datos.setearParametro("@Id_Nacionalidad", Convert.ToInt32(Tb_IdNacionalidad.Text));
                datos.setearParametro("@Id_Genero", Convert.ToInt32(Tb_IdGenero.Text)); 

                datos.ejecutarAccion();
                MessageBox.Show("Usuario modificado con éxito."); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar modificar el usuario: " + ex.Message); 
            }
            finally
            {
                datos.cerrarConexion(); 
            }
        }
    }
}
