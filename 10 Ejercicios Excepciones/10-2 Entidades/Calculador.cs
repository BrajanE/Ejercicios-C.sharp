using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_Entidades
{
    public static class Calculador
    {
        public static float Calcular(float n1, float n2)
        {
            if(n2 == 0)
            {
                throw new DivideByZeroException("No se puede divir por cero");
            }
            return n1 / n2;
        }
    }
}
