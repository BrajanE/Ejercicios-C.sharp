using System;
using System.Collections.Generic;
using _7_2_Entidades;

namespace _7_2_Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "Jon I";
            libro[1] = "Daenerys II";

            Console.WriteLine("Capitulos:");
            for (int i = 0; i < libro[i].Length; i++)
            {
                Console.WriteLine(libro[i]);
            }
            Console.WriteLine("\nNuevos Capitulos");
            //Se cambia el contenido de la pagina
            libro[1] = "Tyrion III";
            //Se agrega una nueva pagina
            libro[2] = "Hojas en blanco";
            for (int i = 0; i < libro[i].Length; i++)
            {
                Console.WriteLine(libro[i]);
            }          
        }
    }
}
