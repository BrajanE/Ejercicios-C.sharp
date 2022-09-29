using System;
using _10__1_Entidades;

namespace _10___1_PruebaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MiClase prueba = new MiClase();
            }
            catch (MiExcepcion ex)
            {
                Console.WriteLine("Error en Consola\n" + ex.Message);
            }

            Console.WriteLine("\n**********\n");

            try 
            {
                MiClase pruebaDos = new MiClase(50);
            }
            catch (UnaExcepcion ex)
            {
                Console.WriteLine("Error en Consola\n" + ex.Message);                
            }
        }
    }
}
