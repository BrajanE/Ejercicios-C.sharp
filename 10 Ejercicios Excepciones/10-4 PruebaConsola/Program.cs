using System;
using _10_4_Entidades;

namespace _10_4_PruebaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Competencia formulaUno = new Competencia(10, 5, ETipoCompetencia.F1);

            MotoCross moto = new MotoCross(12,"Virgolini",300);
       
            //******** No se agregara el vehiculo a la competencia por ser
            // de otro tipo de vehiculo, las excepciones controladas muestran 
            //los datos correspondientes al fallo.

                _ = formulaUno + moto;
         
        }
    }
}
