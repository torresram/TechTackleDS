using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Standar
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        [DisplayName ("Anz. Triple")]
        public Anzuelos AnzTriple { get; set; }
        [DisplayName ("Anz. Simple")]    
        public Anzuelos AnzSimple { get; set; }
        [DisplayName ("Ani. Anzuelo")]
        public Anillas AnillaAnz { get; set; }
        [DisplayName("Ani. Paleta")]
        public Anillas AnillaPal { get; set; }
        [DisplayName("Cartón")]
        public Carton Carton { get; set; }
        public Blister Blister { get; set; }
        [DisplayName("Pitón")]
        public Piton Piton { get; set; }
        public int Cantidad { get; set; }

        public override string ToString()
        {
            return Modelo;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Standar standar = (Standar)obj;
            return AnzSimple == standar.AnzSimple && AnzTriple == standar.AnzTriple && AnillaAnz == standar.AnillaAnz && AnillaPal == standar.AnillaPal;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AnzTriple, AnzSimple, AnillaPal, AnillaAnz);
        }
    }
}
