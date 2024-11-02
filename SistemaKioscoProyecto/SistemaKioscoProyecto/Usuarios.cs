using SistemaKioscoProyecto.Usuario;
using System;
using System.Windows.Forms;

namespace SistemaKioscoProyecto
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarUsuario eliminarUsuario = new EliminarUsuario();
            eliminarUsuario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RestablecerUsuario restablecerUsuario = new RestablecerUsuario();
            restablecerUsuario.Show();
        }
    }
}
