using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
