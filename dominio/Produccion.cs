using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    [Serializable()]
    public class Produccion
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int Carcasas { get; set; }
        public int Armados { get; set; }
        public int Soldados { get; set; }
        public int Lijados { get; set; }

        public override string ToString()
        {
            return Modelo;
        }
    }
    
}