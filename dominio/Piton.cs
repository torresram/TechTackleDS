﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Piton
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int Cantidad { get; set; }
        public float Peso { get; set; }

        public override string ToString()
        {
            return Modelo;
        }
    }
}
