using System;
using _3_4_Entidades;

namespace _3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo bAzul = new Boligrafo(ConsoleColor.Blue,100);
            Boligrafo bRojo = new Boligrafo(ConsoleColor.Red,50);
            string dibujo;
            bAzul.Pintar(75,out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine(bAzul.GetTinta());
            bAzul.Pintar(75, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine(bAzul.GetTinta());
        }
    }
}
