using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_Cotizador
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;           
        }  
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }
        public double GetCantidad()
        {
            return cantidad;
        }

        public static explicit operator Euro(Dolar d)
        {
            double dolares = d.GetCantidad();
            double valorEuros = Euro.GetCotizacion();
            Euro euros = new Euro(dolares / valorEuros);
            return euros;
        }
        public static explicit operator Pesos(Dolar d)
        {
            double dolares = d.GetCantidad();
            double valorPesos = Pesos.GetCotizacion();
            Pesos pesos = new Pesos(dolares * valorPesos);
            return pesos;
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {           
            return d1.GetCantidad() == d2.GetCantidad();
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {           
            return (d1 == d2);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return d == (Dolar)e;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d, Pesos p)
        {
            return d==(Dolar)p;
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());
        }

    }
}
