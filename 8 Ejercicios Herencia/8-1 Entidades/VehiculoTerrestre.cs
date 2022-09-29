using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_Entidades
{
    public class VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.CantidadRuedas = cantidadRuedas;
            this.CantidadPuertas = cantidadPuertas;
            this.Color = color;
        }

        public short CantidadRuedas { get => cantidadRuedas; set => cantidadRuedas = value; }
        public short CantidadPuertas { get => cantidadPuertas; set => cantidadPuertas = value; }
        public Colores Color { get => color; set => color = value; }
    }
}
