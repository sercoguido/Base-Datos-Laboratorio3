using Negocio;
using System;
using System.Windows.Forms;

namespace SistemaKioscoProyecto
{
    public partial class ModificarArticulos : Form
    {
        public ModificarArticulos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificarArticulos_Load(object sender, EventArgs e)
        {

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
                // Configura la consulta para modificar el usuario
                datos.setearConsulta("EXEC ModificarUsuario @Id_Usuario, @Contrasenia, @Nombre, @Apellido, @Email, @FechaNacimiento, @FechaIngreso, @Dni, @Id_Nacionalidad, @Id_Genero", System.Data.CommandType.Text);

                // Establece los parámetros necesarios
                datos.setearParametro("@Id_Usuario", Convert.ToInt32(Tb_IdUsuario.Text)); // ID del usuario
                datos.setearParametro("@Contrasenia", Tb_Contrasenia.Text); // Contraseña del usuario
                datos.setearParametro("@Nombre", Tb_Nombre.Text); // Nombre del usuario
                datos.setearParametro("@Apellido", Tb_Apellido.Text); // Apellido del usuario
                datos.setearParametro("@Email", Tb_Email.Text); // Email del usuario
                datos.setearParametro("@FechaNacimiento", Convert.ToDateTime(Tb_FechaNacimiento.Text)); // Fecha de nacimiento
                datos.setearParametro("@FechaIngreso", Convert.ToDateTime(Tb_FechaIngreso.Text)); // Fecha de ingreso
                datos.setearParametro("@Dni", Tb_Dni.Text); // DNI del usuario
                datos.setearParametro("@Id_Nacionalidad", Convert.ToInt32(Tb_IdNacionalidad.Text)); // ID de nacionalidad
                datos.setearParametro("@Id_Genero", Convert.ToInt32(Tb_IdGenero.Text)); // ID de género

                // Ejecuta la acción en la base de datos
                datos.ejecutarAccion();
                MessageBox.Show("Usuario modificado con éxito."); // Mensaje de éxito
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar modificar el usuario: " + ex.Message); // Manejo de errores
            }
            finally
            {
                datos.cerrarConexion(); // Cierra la conexión
            }
        }
    }
}
