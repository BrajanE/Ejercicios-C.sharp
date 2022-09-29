using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_Entidades
{
    public class Camion : VehiculoTerrestre
    {      
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas,int pesoCarga) 
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.CantidadMarchas = cantidadMarchas;
            this.PesoCarga = pesoCarga;
        }

        public short CantidadMarchas { get => cantidadMarchas; set => cantidadMarchas = value; }
        public int PesoCarga { get => pesoCarga; set => pesoCarga = value; }
    }
}
