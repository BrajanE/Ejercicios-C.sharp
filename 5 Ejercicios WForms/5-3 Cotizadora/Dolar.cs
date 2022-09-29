using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_Cotizadora
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad):this()
        {
            this.cantidad = cantidad;
        }

        public Dolar()
        {
            cantidad = 0;
        }

        public static explicit operator string (Dolar d)
        {

            return cotzRespectoDolar.ToString();
        }
        public static void SetCotizacion(string cotizacion)
        {
            if (double.TryParse(cotizacion, out double aux))
            {
                cotzRespectoDolar = aux;
            }
        }
        public void SetCantidad(string cantIngresada)
        {
            if (double.TryParse(cantIngresada, out double convertCantidad))
            {
                this.cantidad = convertCantidad;
            }
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
            //double dolares = d.GetCantidad();
            //double valorEuros = Euro.GetCotizacion();
            //Euro euros = new Euro(dolares / valorEuros);
            //return euros;
            return new Euro(Euro.GetCotizacion() * d.cantidad);
        }
        public static explicit operator Pesos(Dolar d)
        {
            //double dolares = d.GetCantidad();
            //double valorPesos = Pesos.GetCotizacion();
            //Pesos pesos = new Pesos(dolares * valorPesos);
            //return pesos;
            return new Pesos(Pesos.GetCotizacion() * d.cantidad);
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
            return d == (Dolar)p;
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
