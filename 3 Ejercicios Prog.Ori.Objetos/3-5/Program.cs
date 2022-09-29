using System;
using System.Text;
using _3_5_Entidades;
namespace _3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto vertice1 = new Punto(5,3);
            Punto vertice3 = new Punto(10,2);
            Console.WriteLine(MostrarDatosRectangulo(vertice1, vertice3));
        }
        public static string MostrarDatosRectangulo(Punto v1, Punto v3)
        {
            Rectangulo rectangulo = new Rectangulo(v1,v3);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Medidas de rectangulo");
            sb.AppendLine($"Perimetro - {rectangulo.GetPerimetro()}");
            sb.AppendLine($"Area - {rectangulo.GetArea()}");
            return sb.ToString();
        }
    }
}
