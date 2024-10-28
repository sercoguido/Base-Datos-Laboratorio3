using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaKioscoProyecto
{
    public partial class AgregarVenta : Form
    {
        public AgregarVenta()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarVenta_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int articulo = int.Parse(Tb_Articulo.Text.Trim());
            int cantidad = int.Parse(Tb_Cantidad.Text.Trim());

            AgregarItemVenta(articulo, cantidad);

            //Limpio campos
            Tb_Articulo.Text = "";
            Tb_Cantidad.Text = "";

        }


        public void AgregarItemVenta(int idArticulo, int cantidad)
        {
            // Suponiendo que tienes un DataGridView llamado dgvItemsVentas
            DataGridViewRow row = new DataGridViewRow();

            // Agrega columnas al DataGridView si aún no existen
            if (dgvItemsVentas.Columns.Count == 0)
            {
                dgvItemsVentas.Columns.Add("IdArticulo", "ID Artículo");
                dgvItemsVentas.Columns.Add("Cantidad", "Cantidad");
            }

            // Crear una nueva fila y asignar valores
            row.CreateCells(dgvItemsVentas);
            row.Cells[0].Value = idArticulo;
            row.Cells[1].Value = cantidad;

            // Agregar la fila al DataGridView
            dgvItemsVentas.Rows.Add(row);
        }
    }
}
