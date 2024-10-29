using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dominio
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
        public int IdCategoria { get; set; }
        public int IdMarca { get; set; }
        public int IdProveedor { get; set; }
        public string Descripcion { get; set; } 
        public bool Estado { get; set; }

        public Articulo(int idArticulo, string nombre, int stock, decimal precio, int idCategoria, int idMarca, int idProveedor, string descripcion, bool estado)
        {
            IdArticulo = idArticulo;
            Nombre = nombre;
            Stock = stock;
            Precio = precio;
            IdCategoria = idCategoria;
            IdMarca = idMarca;
            IdProveedor = idProveedor;
            Descripcion = descripcion;
            Estado = estado;
        }

        public Articulo() { }
    }

}
