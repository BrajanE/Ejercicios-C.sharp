﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _15_5_IO
{
    public class PuntoJson <T>: Archivo, IArchivo<T>
        where T: class
    {
        protected override string Extension
        {
            get
            {
                return ".json";
            }
        }

        public void Guardar(string ruta, T contenido)
        {
            if(ValidarExtension(ruta) && ValidarSiExisteElArchivo(ruta))
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
                string archivoJson = JsonSerializer.Serialize(contenido);
                sw.Write(archivoJson);
            }
        }
        public T Leer(string ruta)
        {
            if(ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string archivojson = sr.ReadToEnd();
                    return JsonSerializer.Deserialize<T>(archivojson);
                }
            }
            return null;
        }
    }
}
