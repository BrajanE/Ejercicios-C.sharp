using _10_3_Entidades;
using System;

namespace _10_3_PruebaConsola
{
    internal class Program
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
            Local l5 = new Local("Lugano", 45, "Caballito", 1.99f);
            Local l6 = new Local("Lugano", 30, "Caballito", 2.65f);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.         
            AgregarLLamada(c, l1);
            AgregarLLamada(c, l2);
            AgregarLLamada(c, l3);
            AgregarLLamada(c, l4);
            AgregarLLamada(c, l5);
            AgregarLLamada(c, l6);
            
          
            
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Lista ordenada por Duracion\n");
            c.OrdenarLLamadas();
            Console.WriteLine(c.ToString());

            Console.ReadKey();

            
        }
        public static void AgregarLLamada(Centralita c, LLamada ll)
        {
            try 
            {
                _=c + ll;
            }
            catch(CentralitaException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
