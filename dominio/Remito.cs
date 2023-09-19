﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Remito
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Destino { get; set; }        
        public DateTime Fecha { get; set; }

        public override string ToString()
        {
            return Numero.ToString();
        }
    }
}
