namespace dominio
{
    public class Marca
    {
        public int IdMarca { get; set; }

        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
