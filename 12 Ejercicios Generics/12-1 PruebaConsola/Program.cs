using System;
using _12_1_Entidades;

namespace _12_1_PruebaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TorneoGenerico<EquipoBasquet> torneoBasquet = new TorneoGenerico<EquipoBasquet>("Basquet Elite");
            EquipoBasquet e1 = new EquipoBasquet("e1", DateTime.Now);
            EquipoBasquet e2 = new EquipoBasquet("e2", DateTime.Now);
            EquipoBasquet e3 = new EquipoBasquet("e3", DateTime.Now);
            EquipoBasquet e4 = new EquipoBasquet("e4", DateTime.Now);

            _ = torneoBasquet + e1;
            _ = torneoBasquet + e2;
            _ = torneoBasquet + e3;
            _ = torneoBasquet + e4;

            //Deberia mostrar nombre de torneo y detalle de los equipos
            Console.WriteLine(torneoBasquet.Mostrar()); 
            //Deberia mostrar el puntaje de un partido entre equipos aleatorios
            Console.WriteLine(torneoBasquet.JugarPartido);
        }
    }
}
