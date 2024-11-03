using Negocio;
using System;
using System.Windows.Forms;

namespace SistemaKioscoProyecto
{
    public partial class AgregarArticulos : Form
    {
        public AgregarArticulos()
        {
            InitializeComponent();
        }

        private void Articulos_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarArticulo();
        }





        public void AgregarArticulo()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("EXEC AltaArticulo @Nombre, @Descripcion, @Precio, @Stock, @Id_Marca, @Id_Categoria, @Id_Proveedor", System.Data.CommandType.Text);

                datos.setearParametro("@Nombre", Tb_Nombre.Text);
                datos.setearParametro("@Descripcion", Tb_Descripcion.Text);
                datos.setearParametro("@Precio", Convert.ToDecimal(Tb_Precio.Text));
                datos.setearParametro("@Stock", Convert.ToInt32(Tb_Stock.Text));
                datos.setearParametro("@Id_Marca", Convert.ToInt32(Tb_Marca.Text));
                datos.setearParametro("@Id_Categoria", Convert.ToInt32(Tb_Categoria.Text));
                datos.setearParametro("@Id_Proveedor", Convert.ToInt32(Tb_Proveedor.Text)); // Nuevo parámetro

                // Ejecuto el proceidmiento almacenado
                datos.ejecutarAccion();
                MessageBox.Show("Artículo agregado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error : " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private void Tb_Proveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Tb_Marca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Tb_Categoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Tb_Precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Precio_Click(object sender, EventArgs e)
        {

        }

        private void Tb_Stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Stock_Click(object sender, EventArgs e)
        {

        }

        private void Tb_Nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
