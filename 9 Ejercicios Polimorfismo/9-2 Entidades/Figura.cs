using System;

namespace _9_2_Entidades
{
    public abstract class Figura
    {
        public virtual string Dibujar()
        {
            return "Dibujando forma...";
        }
        public abstract double CalcularSuperficie();
        public abstract double CalcularPerimetro();
    }
}
