using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace dominio
{
    public class Blister
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double Peso { get; set; }

        public override string ToString()
        {
            return Modelo;
        }
    }
}
