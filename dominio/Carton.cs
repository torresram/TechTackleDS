using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Carton
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double Peso { get; set; }

        public override string ToString()
        {
            return Modelo;
        }
    }
}
