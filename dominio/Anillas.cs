using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Anillas
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Tamaño { get; set; }
        public int Cantidad { get; set; }
        public double Peso { get; set; }

        public override string ToString()
        {
            return Tamaño;
        }
    }
}
