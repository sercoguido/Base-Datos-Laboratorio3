using Negocio;
using System;
using System.Windows.Forms;

namespace SistemaKioscoProyecto.Usuario
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarUsuarios();
        }



        public void AgregarUsuarios()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("EXEC AltaUsuario @Contrasenia, @Nombre, @Apellido, @Email, @FechaNacimiento, @FechaIngreso, @Dni, @Id_Nacionalidad, @IdGenero", System.Data.CommandType.Text);

                datos.setearParametro("@Contrasenia", Tb_Contrasenia.Text);
                datos.setearParametro("@Nombre", Tb_Nombre.Text);
                datos.setearParametro("@Apellido", Tb_Apellido.Text);
                datos.setearParametro("@Email", Tb_Email.Text);
                datos.setearParametro("@FechaNacimiento", DTP_FechaNacimiento.Value);
                datos.setearParametro("@FechaIngreso", DateTime.Now);
                datos.setearParametro("@Dni", Tb_Dni.Text);
                datos.setearParametro("@Id_Nacionalidad", Convert.ToInt32(Tb_IdNacionalidad.Text));
                datos.setearParametro("@IdGenero", Convert.ToInt32(Tb_IdGenero.Text));
                datos.ejecutarAccion();
                MessageBox.Show("Usuario agregado con éxito.");
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
