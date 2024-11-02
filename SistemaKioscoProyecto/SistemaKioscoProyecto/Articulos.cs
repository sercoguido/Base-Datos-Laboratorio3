using System;
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

        }
    }
}
