using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Talonarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Prefijo { get; set; }
        public int UltimoRemito { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
