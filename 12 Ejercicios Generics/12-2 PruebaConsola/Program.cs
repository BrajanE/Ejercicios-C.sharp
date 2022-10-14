using System;
using _12_2_Entidades;

namespace _12_2_PruebaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recibo recibo1 = new Recibo();
            Factura factura1 = new Factura(123);
            Factura factura2 = new Factura(456);
            Recibo recibo2 = new Recibo(1104);

            ContabilidadGenerico<Factura, Recibo> contabilidad = new ContabilidadGenerico<Factura, Recibo>();

            contabilidad += recibo1;
            contabilidad += factura1;
            contabilidad += factura2;
            contabilidad += recibo2;

            Console.WriteLine("**Egresos**");

            foreach (Documento item in contabilidad.Egresos)
            {
                Console.WriteLine(item.Numero);
            }

            //Ingreso maneja objetos con Contructor sin parametros
            Console.WriteLine("**Ingresos**");
            foreach (Documento item in contabilidad.Ingresos)
            {
                Console.WriteLine(item.Numero);
            }
        }
    }
}
