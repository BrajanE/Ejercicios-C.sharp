using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_Entidades
{
    public sealed class Cuadrado : Rectangulo
    {
        public Cuadrado(float ladosIguales) 
            : base(ladosIguales, ladosIguales)
        {
        }

        public override string Dibujar()
        {
            return "Dibujando cuadrado";
        }
    }
}
