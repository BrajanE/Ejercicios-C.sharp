using System;
using _6_5_Clases;
namespace _6_5_ejecutable
{
    public class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1("escu1",1);
            AutoF1 a2 = new AutoF1("escu2",4);
            AutoF1 a3 = new AutoF1("escu3",5);
            AutoF1 a4 = new AutoF1("escu1",6);
            AutoF1 a5 = new AutoF1("escu4",4);
            Competencia competencia = new Competencia(5, 10);

            bool hola = competencia + a1;
            hola = competencia + a2;
            hola = competencia + a3;
            hola = competencia + a4;
            hola = competencia + a5;

            Console.WriteLine(competencia.MostrarDatos());

            //EN ESTE CASO AL SACAR A1 PUEDE ENTRAR EN LA LISTA A4
            hola = competencia - a1;
            hola = competencia + a2;
            hola = competencia + a3;
            hola = competencia + a4;
            hola = competencia + a5;

            Console.WriteLine(competencia.MostrarDatos());

            //if (competencia + a1)
            //{
            //    Console.WriteLine(competencia.MostrarDatos());
            //}
            //else
            //{
            //    Console.WriteLine("NO SE AGREGO");
            //}
            //if (competencia + a2)
            //{
            //    Console.WriteLine(competencia.MostrarDatos());
            //}
            //else
            //{
            //    Console.WriteLine("NO SE AGREGO");
            //}
            //if (competencia + a3)
            //{
            //    Console.WriteLine(competencia.MostrarDatos());
            //}
            //else
            //{
            //    Console.WriteLine("NO SE AGREGO");
            //}
            //if (competencia + a4)
            //{
            //    Console.WriteLine(competencia.MostrarDatos());
            //}
            //else
            //{
            //    Console.WriteLine("NO SE AGREGO");
            //}
            //if (competencia + a5)
            //{
            //    Console.WriteLine(competencia.MostrarDatos());
            //}
            //else
            //{
            //    Console.WriteLine("NO SE AGREGO");
            //}
        }
    }
}
