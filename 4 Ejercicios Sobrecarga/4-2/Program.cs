using System;
using _4_2_Cotizador;

namespace _4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar dolares = new Dolar(10/102.65);
            Euro euros = new Euro(10);
            Pesos pesos = new Pesos(10);
            Pesos suma = pesos-euros;

            Console.WriteLine(((Pesos)dolares).GetCantidad());
            Console.WriteLine(((Dolar)pesos).GetCantidad());
            Console.WriteLine(((Pesos)euros).GetCantidad());
            Console.WriteLine(dolares.GetCantidad());
            Console.WriteLine(pesos==dolares);
        }
    }
}
