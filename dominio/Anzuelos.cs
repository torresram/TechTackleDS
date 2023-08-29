using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Anzuelos
    {
        public int Id { get; set; }
        [DisplayName("Número")]
        public string Numero { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public int  Cantidad { get; set; }
        public double Peso { get; set; }

        public override string ToString()
        {
            return Numero;
        }
    }
}
