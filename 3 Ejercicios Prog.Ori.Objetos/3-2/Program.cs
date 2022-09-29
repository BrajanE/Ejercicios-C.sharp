using System;
using _3_2_Entidades;
namespace _3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personas p1 = new Personas("Brajan",new DateTime(1994,02,13),93998529);
            Personas p2 = new Personas("Kevin",new DateTime(1997,02,28),93998529);
            Personas p3 = new Personas("Anabel",new DateTime(2010,09,26),93998529);

            Console.WriteLine($"{p1.Mostrar()}\n");
            Console.WriteLine($"{p2.Mostrar()}\n");
            Console.WriteLine($"{p3.Mostrar()}\n");
        }
    }
}
