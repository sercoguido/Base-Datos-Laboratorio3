using Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaKioscoProyecto
{
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarArticulos agregarArticulos = new AgregarArticulos();
            agregarArticulos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarArticulos modificarArticulos = new ModificarArticulos();
            modificarArticulos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarArticulos eliminarArticulos = new EliminarArticulos();
            eliminarArticulos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RestablecerArticuloscs restablecerArticulos = new RestablecerArticuloscs();
            restablecerArticulos.Show();
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            CargarArticulos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void CargarArticulos()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * FROM view_DetallesArticulo", System.Data.CommandType.Text);

                DataTable tabla = new DataTable();
                datos.ejecutarLectura();
                tabla.Load(datos.Lector);

                Dgv_Articulos.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los artículos: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion(); // Cerrar la conexión después de la consulta
            }
        }
    }
}
