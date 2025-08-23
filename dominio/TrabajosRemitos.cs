using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class TrabajosRemitos
    {
        public int Id { get; set; }
        [DisplayName("Tarea")]
        public Talonarios Talonario { get; set; }
        [DisplayName ("Modelo")]
        public Produccion Produccion { get; set; }
        public int Cantidad { get; set; }
        public string Destino { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Numero { get; set; }

    }
}
