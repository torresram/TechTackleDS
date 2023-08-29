using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace dominio
{
    [Serializable()]
    public class Armado
    {
        public int Id { get; set; }
        public Remito Remito { get; set; }
        [DisplayName ("Señuelo")]
        public Artificial Artificial { get; set; }
        public Color Color { get; set; }
        public int Cantidad { get; set; }

        
    }
}
