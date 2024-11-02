namespace dominio
{
    public class Item_Venta
    {
        public int IdItem { get; set; }
        public int Cantidad { get; set; }
        public int IdArticulo { get; set; }
        public int IdVenta { get; set; }


        public Item_Venta() { }

        public Item_Venta(int idItem, int cantidad, int idArticulo, int idVenta)
        {
            IdItem = idItem;
            Cantidad = cantidad;
            IdArticulo = idArticulo;
            IdVenta = idVenta;
        }
    }
}
