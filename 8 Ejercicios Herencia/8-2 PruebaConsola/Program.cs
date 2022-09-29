using System;
using _8_2_Entidades;

namespace _8_2_PruebaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(3, "utn");
            Jugador j1 = new Jugador(123, "nom1", 5, 20);
            Jugador j2 = new Jugador(485, "nom2", 3, 5);
            Jugador j3 = new Jugador(123, "nom3", 7, 3);
            Jugador j4 = new Jugador(789, "nom4", 3, 5);
            Jugador j5 = new Jugador(567, "nom5", 4, 10);
            DirectorTecnico dt1 = new DirectorTecnico(1, "dt1", new DateTime(1094,02,13));

            Console.WriteLine(equipo.MostrarDatos());

            Console.WriteLine(dt1.MostrarDatos());
        

            if (equipo + j1)
                Console.WriteLine(j1.MostrarDatos());
            else
                Console.WriteLine("NO SE AGREGO \n" + j1.MostrarDatos());

            if (equipo + j2)
               Console.WriteLine(j2.MostrarDatos());
            else
                Console.WriteLine("NO SE AGREGO \n" + j2.MostrarDatos());
            
            //SI SE AGREGA EL J1 NO SE VA A AGREGAR EL J3 POR TENER MISMO DNI
            if (equipo + j3)
                Console.WriteLine(j3.MostrarDatos());
            else
                Console.WriteLine("NO SE AGREGO \n" + j3.MostrarDatos());
          
            if (equipo + j4)
                Console.WriteLine(j4.MostrarDatos());

            else
                Console.WriteLine("NO SE AGREGO \n" + j4.MostrarDatos());

            //NO SE AGREGA J5 POR NO HABER LUGAR
            if (equipo + j5)
                Console.WriteLine(j5.MostrarDatos());

            else
                Console.WriteLine("NO SE AGREGO \n" + j5.MostrarDatos());                    
        }
    }
}
