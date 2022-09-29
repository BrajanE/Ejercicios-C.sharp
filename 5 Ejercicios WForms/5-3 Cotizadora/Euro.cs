namespace _5_3_Cotizadora
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Euro()
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

        public static void SetCotizacion(string cotizacion)
        {
            if (double.TryParse(cotizacion, out double aux))
            {
                cotzRespectoDolar = aux;
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
        public static explicit operator Dolar(Euro e)
        {
            //double cantEuros = e.GetCantidad();
            //double valorDolar = Euro.GetCotizacion();
            //Dolar dolares = new Dolar(cantEuros * valorDolar);
            //return dolares;
            return new Dolar(e.cantidad/Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Euro e)
        {

            //Dolar convertirDolar = (Dolar)e;
            //double valorDolar = Pesos.GetCotizacion();
            //double cantDolares = convertirDolar.GetCantidad();
            //Pesos cantPesos = new Pesos(cantDolares * valorDolar);
            //return cantPesos;
            return (Pesos)((Dolar)e);
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.GetCantidad() == e2.GetCantidad());
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return e == (Euro)p;
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
        }
    }
}
