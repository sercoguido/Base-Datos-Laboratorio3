using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using dominio;
using Negocio;

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
            string EmailCargado = TbEmail.Text;
            string ContraCargada = TbContra.Text;

                int resultado = VerificarEmailYContrasena(EmailCargado, ContraCargada);

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

                    // Muestra el formulario Principal
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

















        //////////////////////////////////ESTO VA EN NEGOCIO, SACAR DE ACÁ
        private void CargarMails()
        {
            // Cadena de conexión a la base de datos
            string connectionString = "server =.\\SQLEXPRESS; database = BBDD_KioscoLab3; integrated security = true";

            // Consulta SQL para obtener todos los registros de la tabla Usuario
            string query = "SELECT Email FROM Usuario";

            // Usamos SqlConnection y SqlDataAdapter para conectarnos y obtener los datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Usamos SqlDataAdapter para ejecutar la consulta y llenar un DataTable
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Mostrar los datos en el DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }



        //ESTO VA EN NEGOCIO, SACAR DE ACÁ
        private void VerificaExistenciaMail()
        {
            // Cadena de conexión a la base de datos
            string connectionString = @"Server=DESKTOP-D071EVB\SQLEXPRESS;Database=BBDD_KioscoLab3;Integrated Security=True;";

            // Consulta SQL para obtener todos los registros de la tabla Usuario
            string query = "SELECT Email FROM Usuario";

            // Usamos SqlConnection y SqlDataAdapter para conectarnos y obtener los datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Usamos SqlDataAdapter para ejecutar la consulta y llenar un DataTable
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Mostrar los datos en el DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        public int VerificarEmailYContrasena(string email, string contrasenia)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=BBDD_KioscoLab3; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = "SELECT CASE " +
                                      "WHEN Email = @Email AND Contrasenia = @Contrasenia THEN 2 " +
                                      "WHEN Email = @Email THEN 1 " +
                                      "ELSE 0 " +
                                      "END " +
                                      "FROM Usuario " +
                                      "WHERE Email = @Email;";
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Contrasenia", contrasenia);
                comando.Connection = conexion;

                conexion.Open();

                object resultObj = comando.ExecuteScalar();

                if (resultObj != null)
                {
                    int result = (int)resultObj;
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
        
}
