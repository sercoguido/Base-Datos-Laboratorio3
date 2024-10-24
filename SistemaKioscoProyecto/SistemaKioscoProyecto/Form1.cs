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

namespace SistemaKioscoProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        private void Form1_Load(object sender, EventArgs e)
        {
            // Llamar al método para cargar los datos al cargar el formulario
            CargarMails();
        }

        private void button1_Click(object sender, EventArgs e)
        {


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
        */
    }
        
}
