using System;
using _3_6_Entidades;
namespace _3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conductores c1 = new Conductores("Brajan");
            c1.SetKmPorDia();
            Conductores c2 = new Conductores("Kevin");
            c2.SetKmPorDia();
            Conductores c3 = new Conductores("Anabel");
            c3.SetKmPorDia();

            int kmDelDia;

            int c1Total = c1.SumaKm();
            int c2Total = c2.SumaKm();
            int c3Total = c3.SumaKm();
            Console.WriteLine("El conductor con mayor kilometraje esta semana: ");
            if (c1Total > c2Total && c1Total > c3Total)
            {               
                Console.WriteLine(c1.Mostrar());
                Console.WriteLine($"Kilometraje total: {c1Total}");
                
            }else if(c2Total>=c1Total && c2Total > c3Total)
            {
                Console.WriteLine(c2.Mostrar());
                Console.WriteLine($"Kilometraje total: {c2Total}");
            } else if (c3Total>c1Total && c3Total > c2Total)
            {
                Console.WriteLine(c3.Mostrar());
                Console.WriteLine($"Kilometraje total: {c3Total}");
            }
            Console.WriteLine("***********************\n");
            kmDelDia = 2;
            Console.WriteLine("El conductor con mayor kilometraje el 3° dia: ");
            if (c1.GetKm(kmDelDia) > c2.GetKm(kmDelDia) && c1.GetKm(kmDelDia) > c3.GetKm(kmDelDia))
            {
                Console.WriteLine($"Conductor: {c1.GetNombre()}");
                Console.WriteLine($"Kilometraje del 3° dia: {c1.GetKm(kmDelDia)}");

            }
            else if (c2.GetKm(kmDelDia) >= c1.GetKm(kmDelDia) && c2.GetKm(kmDelDia) > c3.GetKm(kmDelDia))
            {
                Console.WriteLine($"Conductor: {c2.GetNombre()}");
                Console.WriteLine($"Kilometraje del 3° dia: {c2.GetKm(kmDelDia)}");
            }
            else if (c3.GetKm(kmDelDia) > c1.GetKm(kmDelDia) && c3.GetKm(kmDelDia) > c2.GetKm(kmDelDia))
            {
                Console.WriteLine($"Conductor: {c3.GetNombre()}");
                Console.WriteLine($"Kilometraje del 3° dia: {c3.GetKm(kmDelDia)}");
            }

            Console.WriteLine("***********************\n");
            kmDelDia = 4;
            Console.WriteLine("El conductor con mayor kilometraje el 5° dia: ");
            if (c1.GetKm(kmDelDia) > c2.GetKm(kmDelDia) && c1.GetKm(kmDelDia) > c3.GetKm(kmDelDia))
            {
                Console.WriteLine($"Conductor: {c1.GetNombre()}");
                Console.WriteLine($"Kilometraje del 5° dia: {c1.GetKm(kmDelDia)}");

            }
            else if (c2.GetKm(kmDelDia) >= c1.GetKm(kmDelDia) && c2.GetKm(kmDelDia) > c3.GetKm(kmDelDia))
            {
                Console.WriteLine($"Conductor: {c2.GetNombre()}");
                Console.WriteLine($"Kilometraje del 5° dia: {c2.GetKm(kmDelDia)}");
            }
            else if (c3.GetKm(kmDelDia) > c1.GetKm(kmDelDia) && c3.GetKm(kmDelDia) > c2.GetKm(kmDelDia))
            {
                Console.WriteLine($"Conductor: {c3.GetNombre()}");
                Console.WriteLine($"Kilometraje del 5° dia: {c3.GetKm(kmDelDia)}");
            }

        }
    }
}
