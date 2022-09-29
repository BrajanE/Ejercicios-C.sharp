using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_Conversor
{
    public class NumeroBinario
    {
        private string numero;

        public string Numero { get => numero; set => numero = value; }

        private NumeroBinario(string numero)
        {
            this.Numero = numero;
        }

        public static explicit operator NumeroBinario(string numeroBinario)
        {
            return new NumeroBinario(numeroBinario);
        } 
        public static explicit operator NumeroDecimal(NumeroBinario numeroBinario)
        {
            return (NumeroDecimal)Conversor.ConvertirBinarioADecimal(numeroBinario.Numero);
        }

        public static bool operator == (NumeroBinario nb,NumeroDecimal nd)
        {
            return nb.Numero == ((NumeroBinario)nd).Numero;
        }
        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            return !(nb == nd);
        }
        public static string operator +(NumeroBinario nb, NumeroDecimal nd)
        {
            double resultadoDecimal = ((NumeroDecimal)nb).Numero + nd.Numero;
            return Conversor.ConvertirDecimalABinario(resultadoDecimal);
        }
        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            double resultadoDecimal = ((NumeroDecimal)nb).Numero - nd.Numero;
            return Conversor.ConvertirDecimalABinario(resultadoDecimal);
        }
    }
}
