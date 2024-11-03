using System;
using System.Windows.Forms;

namespace SistemaKioscoProyecto
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarVenta agregarVenta = new AgregarVenta();
            agregarVenta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            articulos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Marcas marcas = new Marcas();
            marcas.Show();
        }
    }
}
