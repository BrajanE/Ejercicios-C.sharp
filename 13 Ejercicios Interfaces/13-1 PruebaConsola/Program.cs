using System;
using _13_1_Entidades;

namespace _13_1_PruebaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            EscrituraWrapper eLapiz = miLapiz.Escribir("Escritura con Lapiz");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Escritura con Boligrafo");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            //SEGUNDA PARTE

            Lapiz l2 = new Lapiz(10);
            Lapiz l3 = new Lapiz(10);
            Boligrafo b2 = new Boligrafo(20, ConsoleColor.Green);
            Boligrafo b3 = new Boligrafo(20, ConsoleColor.Green);

            CartucheraMultiuso cartucheraMult = new CartucheraMultiuso();
            cartucheraMult.Acciones.Add(miLapiz);
            cartucheraMult.Acciones.Add(miBoligrafo);
            cartucheraMult.Acciones.Add(l2);
            cartucheraMult.Acciones.Add(l3);
            cartucheraMult.Acciones.Add(b2);
            cartucheraMult.Acciones.Add(b3);
            cartucheraMult.RecorrerElementos();

            CartucheraSimple cartucheraSimpl = new CartucheraSimple();
            cartucheraSimpl.ListaBoligrafo.Add(miBoligrafo);
            cartucheraSimpl.ListaLapiz.Add(miLapiz);
            cartucheraSimpl.RecorrerElementos();

            Console.ReadKey();
        }
    }
}
