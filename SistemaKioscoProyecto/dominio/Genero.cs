using System.ComponentModel;

namespace dominio
{
    public class Genero
    {
        public int IdGenero { get; set; }

        [DisplayName("Nombre de Género")]
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
