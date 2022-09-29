using System;
using _8_3_Entidades;

namespace _8_3_PuestaPrueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Competencia formulaUno = new Competencia(10, 5, ETipoCompetencia.F1);
            AutoF1[] autos = new AutoF1[10];

            //No se agregaran los 5 vehiculos restantes, ya que la lista es de 5

            for (int i = 0; i<autos.Length;i++)
            {
                autos[i] = new AutoF1((short)i, random.Next(1,5).ToString(), (short)random.Next(740,1000));
                if(formulaUno + autos[i])
                {
                    Console.WriteLine($"Se agrego el siguiente auto a la competencia: {autos[i].MostrarDatos()}");
                }
                else
                {
                    Console.WriteLine($"No se agrego: {autos[i].MostrarDatos()}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("<-------------------------------------------------------------------------->");
            Console.WriteLine(formulaUno.MostrarDatos());

            Console.ReadKey();
        }
    }
}
