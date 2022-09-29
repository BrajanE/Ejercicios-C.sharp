using System.Collections.Generic;
using System.Text;

namespace _6_3
{
    public class LogicaForm
    {
        public static Dictionary<string, int> ObtenerContadorPalabras(string texto)
        {
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();


            //split separa un texto segun un caracter criterio en este caso espacio
            //retorna un array de strings, stringSplitOption nos da mas herramientas
            //en este caso no suma los elementos vacio en caso de haberlos
            string[] palabras = texto.Split(' ',System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string palabra in palabras)
            {
                if (!contadorPalabras.ContainsKey(palabra))
                {
                    contadorPalabras.Add(palabra, 1);
                }
                else
                {
                    //En este caso entramos dentro del key y le aumentamos el valor
                    //por cada palabra repetida que se encuentre
                    contadorPalabras[palabra]++;
                }
            }
            return contadorPalabras;
        }
        public static int CompararCantidadRepeticiones(KeyValuePair<string, int> elem1, KeyValuePair<string, int> elem2)
        {
            //Si el segundo elemento es mas chico que el primero devuelve negativo
            return elem2.Value - elem1.Value;
        }
        public static string MostrarPalabras(List<KeyValuePair<string, int>> listaPalabras)
        {
            StringBuilder sb = new StringBuilder();
            if (listaPalabras.Count == 0)
            {
                sb.AppendLine("No se ingresaron palabras");
            }
            else
            {
                //foreach (KeyValuePair<string, int> par in listaPalabras)
                //{
                //    sb.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                //}
                for (int i = 0; i < 3 && i<listaPalabras.Count ; i++)
                {
                    KeyValuePair<string, int> par = listaPalabras[i];
                    sb.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                }
            }

            return sb.ToString();
        }

    }
}
