using System;
using _9_3_Entidades;

namespace _9_3_PruebaConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", EFranja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(EFranja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.         
            _= c + l1;
            //_= c + l2;
            _= c + l3;
            //El l4 no se agrega por ser el mismo que el l2
            //_= c + l4;
            Console.WriteLine("Lista ordenada por Duracion\n");
            c.OrdenarLLamadas();
            Console.WriteLine(c.ToString());

            Console.ReadKey();
        }
    }
}
