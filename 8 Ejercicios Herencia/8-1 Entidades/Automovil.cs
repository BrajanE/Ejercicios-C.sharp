using System;

namespace _8_1_Entidades
{
    public enum Colores
    {
        Rojo, Blanco, Azul, Gris, Negro
    }
    public class Automovil : VehiculoTerrestre
    {       
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas,int cantidadPasajeros) 
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.CantidadMarchas = cantidadMarchas;
            this.CantidadPasajeros = cantidadPasajeros;
        }

        public short CantidadMarchas { get => cantidadMarchas; set => cantidadMarchas = value; }
        public int CantidadPasajeros { get => cantidadPasajeros; set => cantidadPasajeros = value; }
    }
}
