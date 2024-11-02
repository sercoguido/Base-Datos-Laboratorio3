using System.ComponentModel;

namespace dominio
{
    public class Nacionalidad
    {
        public int IdNacionalidad { get; set; }

        [DisplayName("País")]
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
