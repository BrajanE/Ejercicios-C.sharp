using System;
using _3_7_Entidades;

namespace _3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mascota m1 = new Mascota("Perro", "Tonton", new DateTime(2007, 03, 01),"Sin vacuna");
            Mascota m2 = new Mascota("Gato", "Mumu", new DateTime(2010, 05, 10), "Triple Felina");

            Mascota m3 = new Mascota("Gato", "Mimi", new DateTime(2015, 10, 25),"Sin vacuna");
            Mascota m4 = new Mascota("Perro", "Chiquita", new DateTime(2007, 05, 10), "Contra Rabia");          
            
            Persona p1 = new Persona("Lugano", "Brajan", "Estrada", 0);
            Persona p2 = new Persona("Boedo", "Ayelen", "Agustini", 0);
            Persona p3 = new Persona("Ramos Mejia", "Fernando", "Saibene", 0);

            p1.SetMascota(m1);
            p2.SetMascota(m2);
            p3.SetMascota(m3);
            p3.SetMascota(m4);

            Console.WriteLine(p1.MostrarDatosClientes());
            Console.WriteLine(p2.MostrarDatosClientes());
            Console.WriteLine(p3.MostrarDatosClientes());
      
           
            
            



        }
    }
}
