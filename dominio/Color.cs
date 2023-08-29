using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace dominio
{
    [Serializable()]
    public class Color
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Modelo;
        }
    }
}
