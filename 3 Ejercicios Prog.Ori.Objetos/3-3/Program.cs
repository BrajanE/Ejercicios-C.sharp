using System;
using System.Collections.Generic;
using _3_3_Entidades;

namespace _3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Estrada", "1001", "Brajan");
            Estudiante e2 = new Estudiante("Alonso", "2002", "Hernan");
            Estudiante e3 = new Estudiante("Gomez", "3003", "Jaime");
            e1.SetNotaPrimerParcial(5);
            e1.SetNotaSegundoParcial(7);
            e2.SetNotaPrimerParcial(8);
            e2.SetNotaSegundoParcial(9);
            e3.SetNotaPrimerParcial(2);
            e3.SetNotaSegundoParcial(3);
            List < Estudiante > listaE = new List<Estudiante>();
            listaE.Add(e1);
            listaE.Add(e2);
            listaE.Add(e3);
            foreach (Estudiante e in listaE)
            {
                Console.WriteLine(e.Mostrar());
            }
        }
    }
}
