namespace _4_2_Cotizador
{
    public class Pesos
    {
        private double cantidad;
        private static double cotzRespectoDolar;
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        static Pesos()
        {
            cotzRespectoDolar = 102.65;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }
        public double GetCantidad()
        {
            return cantidad;
        }
        public static explicit operator Dolar(Pesos p)
        {
            double cantPesos = p.GetCantidad();
            double valorDolar = GetCotizacion();
            Dolar cantDolares = new Dolar(cantPesos / valorDolar);
            return cantDolares;
        }
        public static explicit operator Euro(Pesos p)
        {
            Dolar convertirDolar = (Dolar)p;          
            Euro cantEuros = (Euro)convertirDolar;
            return cantEuros;
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
