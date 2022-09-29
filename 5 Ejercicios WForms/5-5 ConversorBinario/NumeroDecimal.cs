using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_ConversorBinario
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.Numero = numero;
        }

        public double Numero { get => numero; set => numero = value; }

        public static explicit operator NumeroDecimal(double numeroDecimal)
        {
            return new NumeroDecimal(numeroDecimal);
        }
        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return (NumeroBinario)Conversor.ConvertirDecimalABinario(numeroDecimal.Numero);
        }

        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        {
            return nd.Numero == ((NumeroDecimal)nb).Numero;
        }
        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {
            return !(nd == nb);
        }
        public static double operator +(NumeroDecimal nd, NumeroBinario nb)
        {
            double resultado = nd.Numero + ((NumeroDecimal)nb).Numero;
            return resultado;
        }
        public static double operator -(NumeroDecimal nd, NumeroBinario nb)
        {
            double resultado = nd.Numero - ((NumeroDecimal)nb).Numero;
            return resultado;
        }
    }
}
