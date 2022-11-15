using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace _15_4_Consola
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        public Persona()
        {
        }    
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.Append($"Apellido: {this.Apellido}");
            return sb.ToString();
        }

        //*********************************************************************     

        public static void GuardarXml(Persona p, string ruta)
        {
            try
            {
                using (StreamWriter archivoXml = new StreamWriter(ruta))
                {
                    XmlSerializer escritorXml = new XmlSerializer(typeof(Persona));
                    escritorXml.Serialize(archivoXml, p);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error al guardar archivo");
                Console.WriteLine(ex.Message);
            }
        }
        public static Persona LeerXml(string rutaArchivo)
        {
            Persona p = null;
            try
            {
                if (File.Exists(rutaArchivo))
                {
                    using (StreamReader archivoXml = new StreamReader(rutaArchivo))
                    {
                        XmlSerializer lectorXml = new XmlSerializer(typeof(Persona));
                        p = (Persona)lectorXml.Deserialize(archivoXml);
                    }
                }
            }
            catch
            {

            }
            return p;
        }

        public static void GuardarJson(Persona p, string rutaArchivo)
        {
            try
            {
                string archivoJson = JsonSerializer.Serialize(p);
                File.WriteAllText(rutaArchivo, archivoJson);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error al guardar archivo");
                Console.WriteLine(ex.Message);
            }
        }
        public static Persona LeerJson(string rutaArchivo)
        {
            Persona p = null;
            if (File.Exists(rutaArchivo))
            {
                try
                {
                    string archivoJson = File.ReadAllText(rutaArchivo);
                    p = JsonSerializer.Deserialize<Persona>(archivoJson);
                }
                catch (JsonException ex)
                {
                    Console.WriteLine("Error al leer archivo");
                    Console.WriteLine(ex.Message);
                }
            }
            return p;
        }
    }
}
