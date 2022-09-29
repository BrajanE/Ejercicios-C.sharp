using System;
using _4_1_Sumador;

namespace _4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sum1=new Sumador();            
            string resultadoStr1 = sum1.Sumar("hola", " mundo");
            int resultadoInt1 = (int)sum1.Sumar(5,2);

            Sumador sum2=new Sumador();            
            string resultadoStr2 = sum2.Sumar("hola", " mundo");

            Console.WriteLine($"Sumador 1°: {(int)sum1}");
            Console.WriteLine($"Sumador 2°: {(int)sum2}");
            Console.WriteLine(sum1+sum2);
            Console.WriteLine(sum1|sum2);
        }
    }
}
