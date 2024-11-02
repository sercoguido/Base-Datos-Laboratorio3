using Negocio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaKioscoProyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Llamar al método para cargar los datos al cargar el formulario
            CargarMails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            string EmailCargado = TbEmail.Text;
            string ContraCargada = TbContra.Text;

            int resultado = usuarioNegocio.VerificarEmailYContrasena(EmailCargado, ContraCargada);

            switch (resultado)
            {
                case 0:
                    ErrMail.Text = "El mail ingresado no se encuentra en nuestra Base de datos.";
                    break;
                case 1:
                    ErrMail.Text = "";
                    ErrContra.Text = "Contraseña no coincide.";
                    break;
                case 2:
                    Principal principalForm = new Principal();

                    principalForm.Show();

                    break;

            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

















        //////////////////////////////////ESTO ELIMINAR LUEGO, ES PRUEBA
        private void CargarMails()
        {
            string connectionString = "server =.\\SQLEXPRESS; database = BBDD_KioscoLab3; integrated security = true";

            string query = "SELECT Email FROM Usuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }





        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
