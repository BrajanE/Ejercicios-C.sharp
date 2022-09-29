using System;
using System.Text;

namespace _4_4__Estanteria
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return marca;
        }
        public float GetPrecio()
        {
            return precio;
        }
        public static string MostrarProfucto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"**Datos de Producto**");
            sb.AppendLine($"Marca: {p.GetMarca()}");
            sb.AppendLine($"Precio: {p.GetPrecio()}");
            return sb.ToString();
        }
        public static bool operator ==(Producto p, string marca)
        {
            return (p.GetMarca() == marca);
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            if(p1 is not null && p2 is not null)
            {
                return ((p1.GetMarca() == p2.GetMarca()) && (p1.codigoDeBarra == p2.codigoDeBarra));
            }
            return false;
            
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
     }
}
