using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _15_5_IO
{
    public class PuntoXml <T>: Archivo, IArchivo<T>
        where T : class
    {
        protected override string Extension
        {
            get { return ".xml"; }
        }

        public void Guardar(string ruta, T contenido)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }

        public void GuardarComo(string ruta, T contenido)
        {
            if (ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }        
        private void Serializar(string ruta,T contenido)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                XmlSerializer archivoXml = new XmlSerializer(typeof(T));
                archivoXml.Serialize(sw, contenido);
            }
        }
        public T Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    XmlSerializer archivoXml = new XmlSerializer(typeof(T));
                    return  (T)archivoXml.Deserialize(sr);
                }
            }
            return null;
        }
    }
}
