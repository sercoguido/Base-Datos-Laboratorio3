using System;
using System.ComponentModel;

namespace dominio
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }

        [DisplayName("Contraseña")]
        public string Contrasenia { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Email { get; set; }

        public string Dni { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public DateTime FechaIngreso { get; set; }

        public Genero genero { get; set; }

        public Nacionalidad nacionalidad { get; set; }
    }
}
