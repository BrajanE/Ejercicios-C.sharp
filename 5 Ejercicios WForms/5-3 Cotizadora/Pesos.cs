using System;

namespace _5_3_Cotizadora
{
    public class Pesos
    {
        private double cantidad;
        private static double cotzRespectoDolar;
        public Pesos(double cantidad):this()
        {
            this.cantidad = cantidad;
        }
        static Pesos()
        {
            cotzRespectoDolar = 102.65;
        }

        public Pesos()
        {
            cantidad = 0;
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
        public static void SetCotizacion(string cotizacion)
        {
            if (double.TryParse(cotizacion, out double aux))
            {
                cotzRespectoDolar = aux;
            }
        }
        public double GetCantidad()
        {
            return cantidad;
        }
        public static explicit operator Dolar(Pesos p)
        {
            //double cantPesos = p.GetCantidad();
            //double valorDolar = GetCotizacion();
            //Dolar cantDolares = new Dolar(cantPesos / valorDolar);
            //return cantDolares;
            return new Dolar(p.cantidad / Pesos.GetCotizacion());
        }
        public static explicit operator Euro(Pesos p)
        {
            //Dolar convertirDolar = (Dolar)p;
            //Euro cantEuros = (Euro)convertirDolar;
            //return cantEuros;
            return new Euro(p.cantidad/Euro.GetCotizacion());
        }
        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Pesos p, Dolar d)
        {
            return p == (Pesos)d;
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            return p == (Pesos)e;
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }
        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad() - ((Pesos)d).GetCantidad());
        }
        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad() + ((Pesos)d).GetCantidad());
        }
        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.GetCantidad() - ((Pesos)e).GetCantidad());
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.GetCantidad() + ((Pesos)e).GetCantidad());
        }
    }
}

