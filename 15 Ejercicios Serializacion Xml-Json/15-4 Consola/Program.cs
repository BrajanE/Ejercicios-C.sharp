using System;
using System.IO;

namespace _15_4_Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = Directory.GetCurrentDirectory();
            string rutaCompleta = Path.Combine(ruta, "persona");
            Persona p1 = new Persona("Brajan", "Estrada");

            Console.WriteLine("Datos a originales:");
            Console.WriteLine(p1.ToString());
            Console.WriteLine("\n*******************************************\n");

            Console.WriteLine("XML - Serializacion y Deserializacion");
            Persona.GuardarXml(p1, rutaCompleta);

            Persona pXml = Persona.LeerXml(rutaCompleta);
            Console.WriteLine(pXml.ToString());

            Console.WriteLine("\n*******************************************\n");

            Console.WriteLine("JSON - Serializacion y Deserializacion");
            Persona.GuardarJson(p1, rutaCompleta);

            Persona pJson = Persona.LeerJson(rutaCompleta);
            Console.WriteLine(pJson.ToString());
        }
    }
}
