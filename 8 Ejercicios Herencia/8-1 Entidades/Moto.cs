﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_Entidades
{
    public class Moto : VehiculoTerrestre
    {
        
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada) 
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.Cilindrada = cilindrada;
        }

        public short Cilindrada { get => cilindrada; set => cilindrada = value; }
    }
}
