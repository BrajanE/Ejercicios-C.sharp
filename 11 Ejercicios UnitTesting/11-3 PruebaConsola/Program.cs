using System;
using System.IO;
using _11_3_Entidades;
using _14_4_IO_Consola;

namespace _11_3_PruebaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = Directory.GetCurrentDirectory() + DateTime.Now.ToString("yyyyMMdd")+".txt";
            try
            {
                MiClase prueba = new MiClase();
            }
            catch (MiExcepcion ex)
            {
                _14_4_ArchivoTexto.Guardar($"{ex.Message}",$"{ruta}");
            }

            Console.WriteLine(_14_4_ArchivoTexto.Leer($"{ruta}"));

            try
            {
                MiClase pruebaDos = new MiClase(50);
            }
            catch (UnaExcepcion ex)
            {
                _14_4_ArchivoTexto.Guardar($"{ex.Message}", $"{ruta}");
            }
            Console.WriteLine("********************");
            Console.WriteLine(_14_4_ArchivoTexto.Leer($"{ruta}"));
        }
    }
}
