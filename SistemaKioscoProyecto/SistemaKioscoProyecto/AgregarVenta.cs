using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Negocio;

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
            // Asegúrate de que los valores se puedan convertir
            if (int.TryParse(Tb_Articulo.Text.Trim(), out int articulo) && int.TryParse(Tb_Cantidad.Text.Trim(), out int cantidad))
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();

                // Verificar si se puede restar el stock
                if (articuloNegocio.PuedeRestarStock(articulo, cantidad))
                {
                    if (ArticuloYaAgregado(articulo, cantidad, out int filaExistente))
                    {
                        int cantidadActual = Convert.ToInt32(dgvItemsVentas.Rows[filaExistente].Cells["Cantidad"].Value);
                        int nuevaCantidad = cantidadActual + cantidad;
                        dgvItemsVentas.Rows[filaExistente].Cells["Cantidad"].Value = nuevaCantidad;

                        // Obtener el precio del artículo (asumiendo que tienes un método para esto)
                        decimal precioArticulo = articuloNegocio.ObtenerPrecioArticulo(articulo);

                        // Actualizar el precio total
                        decimal nuevoPrecioTotal = nuevaCantidad * precioArticulo;
                        dgvItemsVentas.Rows[filaExistente].Cells["ValorTotal"].Value = nuevoPrecioTotal;
                    }
                    else
                    {
                        // Obtener el nombre y el precio del artículo
                        string nombreArticulo = articuloNegocio.ObtenerNombreArticulo(articulo);
                        decimal precioArticulo = articuloNegocio.ObtenerPrecioArticulo(articulo);

                        // Agregar el artículo a la venta
                        AgregarItemVenta(articulo, nombreArticulo, cantidad, precioArticulo);
                    }


                    // Limpiar campos
                    Tb_Articulo.Text = "";
                    Tb_Cantidad.Text = "";
                }
                else
                {
                    MessageBox.Show("No es posible realizar la operación. Stock insuficiente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos para el artículo y la cantidad.");
            }
        }






        public void AgregarItemVenta(int idArticulo, string nombreArticulo, int cantidad, decimal precioArticulo)
        {
            DataGridViewRow row = new DataGridViewRow();

            // Agregar columnas si aún no existen
            if (dgvItemsVentas.Columns.Count == 0)
            {
                dgvItemsVentas.Columns.Add("IdArticulo", "ID Artículo");
                dgvItemsVentas.Columns.Add("NombreArticulo", "Nombre Artículo");
                dgvItemsVentas.Columns.Add("Cantidad", "Cantidad");
                dgvItemsVentas.Columns.Add("Precio", "Precio Unitario");
                dgvItemsVentas.Columns.Add("ValorTotal", "Valor Total");
            }

            // Calcular el valor total
            decimal valorTotal = cantidad * precioArticulo;

            // Crear una nueva fila y asignar valores
            row.CreateCells(dgvItemsVentas);
            row.Cells[0].Value = idArticulo;
            row.Cells[1].Value = nombreArticulo; // Agregar el nombre del artículo
            row.Cells[2].Value = cantidad;
            row.Cells[3].Value = precioArticulo; // Agregar el precio unitario
            row.Cells[4].Value = valorTotal; // Agregar el valor total

            // Agregar la fila al DataGridView
            dgvItemsVentas.Rows.Add(row);
        }

        private bool ArticuloYaAgregado(int idArticulo, int cantidad, out int filaExistente)
        {
            for (int i = 0; i < dgvItemsVentas.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvItemsVentas.Rows[i].Cells["IdArticulo"].Value) == idArticulo)
                {
                    filaExistente = i; // Guardar el índice de la fila existente
                    return true; // El artículo ya está agregado
                }
            }
            filaExistente = -1; // Indicar que no se encontró el artículo
            return false; // El artículo no está agregado
        }
    }
}
