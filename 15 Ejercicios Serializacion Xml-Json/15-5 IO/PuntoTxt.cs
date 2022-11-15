using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_5_IO
{
    public class PuntoTxt : Archivo, IArchivo<string>     
    {
        protected override string Extension
        {
            get
            {
                return ".txt";
            }
        }

        public void Guardar(string ruta, string contenido)
        {
            if(ValidarExtension(ruta) && ValidarSiExisteElArchivo(ruta))
            {
                Serializar(ruta, contenido);
            }
        }

        public void GuardarComo(string ruta, string contenido)
        {
            if (ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }
        private void Serializar(string ruta, string contenido)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine(contenido);
            }
        }
        public string Leer(string ruta)
        {
            if(ValidarExtension(ruta) && ValidarSiExisteElArchivo(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    return sr.ReadToEnd();
                }
            }
            return String.Empty;
        }
    }
}
