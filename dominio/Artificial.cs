using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace dominio
{
    public class Artificial
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public Color Color { get; set; }
        public string Modelo { get; set; }
        public string Imagen { get; set; }
        public int Cantidad { get; set; }
        public double Peso { get; set; }

        public override string ToString()
        {
            return Modelo;
        }
    }

}
