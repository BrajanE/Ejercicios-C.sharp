using System;

namespace _5_5_ConversorBinario
{
    public static class Conversor
    {
        public static string ConvertirDecimalABinario(double numeroEntero)
        {

            string binario = string.Empty;
            int resultDiv = (int)numeroEntero;
            int restoDiv;
            if (resultDiv >= 0)
            {
                do
                {
                    restoDiv = resultDiv % 2;
                    resultDiv /= 2;
                    binario = restoDiv.ToString() + binario; ;

                } while (resultDiv > 0);
            }
            return binario;
            //string binario = "";
            //if (numeroEntero > 0)
            //{
            //    while (numeroEntero > 0)
            //    {
            //        binario = numeroEntero % 2 + binario;
            //        numeroEntero = numeroEntero / 2;
            //    }
            //    return binario;
            //}
            //return "ERROR";
        }
        public static double ConvertirBinarioADecimal(string numeroBinario)
        {
            double resultado = 0;
            int cantidadCaracteres = numeroBinario.Length;
            foreach (char ch in numeroBinario)
            {
                cantidadCaracteres--;
                if (ch == '1')
                {
                    resultado += (int)Math.Pow(2, cantidadCaracteres);
                }
            }
            return resultado;
        }
    }

}
