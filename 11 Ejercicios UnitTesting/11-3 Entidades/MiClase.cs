using System;

namespace _11_3_Entidades
{
    public class MiClase
    {
        public MiClase()
        {

            try
            {
                int numero = MiClase.DivisionPorCero(50, 0);
            }
            catch (Exception ex)
            {
                throw new MiExcepcion("Error 1: No se puede dividir por cero\n" + ex.Message);

            }
            Console.WriteLine("***Primer constructor terminado***");

        }
        public MiClase(int numero)
        {
            try
            {
                MiClase pruebaDos = new MiClase();
            }
            catch (Exception ex)
            {
                throw new UnaExcepcion("Error 2: Segunda division por cero\n" + ex.Message);
            }
            Console.WriteLine("***Segundo constructor terminado***");
        }

        static public int DivisionPorCero(int numero, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Mensaje original");
            }
            return numero / divisor;

        }
    }
}
