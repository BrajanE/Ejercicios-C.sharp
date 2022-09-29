using System;

namespace _4_3_Conversor
{
    public static class Conversor
    {
        public static string ConvertirDecimalABinario(double numeroEntero)
        {
            string binario = "";
            if (numeroEntero > 0)
            {
                while (numeroEntero > 0)
                {
                    binario = numeroEntero % 2 + binario;
                    numeroEntero = numeroEntero / 2;
                }
                return binario;
            }
            return "ERROR";
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
