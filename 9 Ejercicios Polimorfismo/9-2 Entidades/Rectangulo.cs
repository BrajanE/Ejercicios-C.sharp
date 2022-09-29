using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_Entidades
{
    public class Rectangulo : Figura
    {
        private float longitudBase;
        private float longitudAltura;

        public Rectangulo(float longitudBase, float longitudAltura)
        {
            this.longitudBase = longitudBase;
            this.longitudAltura = longitudAltura;
        }      
        public override double CalcularPerimetro()
        {
            return (longitudBase+longitudAltura)*2;
        }

        public override double CalcularSuperficie()
        {
            return longitudAltura*longitudBase;
        }

        public override string Dibujar()
        {
            return "Dibujando rectangulo";
        }
    }
}
