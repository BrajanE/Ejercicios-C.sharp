using System.Text;

namespace _4_4__Estanteria
{
    public class Estante
    {
        private Producto[] preoductos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.preoductos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacionEstante): this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }
        public Producto[] GetProductos()
        {
            return this.preoductos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"**Datos del Estante**");
            sb.AppendLine($"Ubicacion: {e.ubicacionEstante}");
            sb.AppendLine($"Productos contenidos");           
            foreach (Producto p in e.preoductos)
            {
                sb.AppendLine($"{Producto.MostrarProfucto(p)}");
            }
            return sb.ToString();
        }
        public static bool operator == (Estante e, Producto p)
        {
            foreach (Producto p1 in e.preoductos)
            {
                if(p1 == p)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {        
            return !(e==p);
        }
        public static bool operator +(Estante e, Producto p)
        {
            if (e is not null)
            {
                for (int i = 0; i < e.preoductos.Length; i++)
                {
                    if (e.preoductos[i] is null && !(e==p))
                    {
                        e.preoductos[i] = p;
                        return true;
                    }
                }

            }
            return false;
        }
        public static Estante operator - (Estante e, Producto p)
        {
            if (e is not null)
            {
                for (int i = 0; i < e.preoductos.Length; i++)
                {
                    if (e == p)
                    {
                        e.preoductos[i] = null;
                        return e;
                    }
                }

            }
            return e;
        }
    }
}
