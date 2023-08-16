using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Insumos
    {
        public int Id { get; set; }
        [DisplayName("Item")]
        public string Familia { get; set; }
        [DisplayName("Medida")]
        public string Item { get; set; }
        public int Cantidad { get; set; }
        public double Peso { get; set; }

        public override string ToString()
        {
            return Item;
        }
    }
}
