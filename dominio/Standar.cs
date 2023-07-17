using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Standar
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public Anzuelos AnzTriple { get; set; }
        public Anzuelos AnzSimple { get; set; }
        public Anillas AnillaAnz { get; set; }
        public Anillas AnillaPal { get; set; }
        public Carton Carton { get; set; }
        public Blister Blister { get; set; }

        public override string ToString()
        {
            return Modelo;
        }
    }
}
