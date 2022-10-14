using System.Collections.Generic;

namespace _12_2_Entidades
{
    public class ContabilidadGenerico<T, U>
        where T : Documento
        where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public ContabilidadGenerico()
        {
            egresos = new List<T>();
            ingresos = new List<U>();

        }

        public List<T> Egresos { get => egresos; set => egresos = value; }
        public List<U> Ingresos { get => ingresos; set => ingresos = value; }

        public static ContabilidadGenerico<T, U> operator +(ContabilidadGenerico<T, U> c, T egreso)
        {
            if (egreso is not null)
            {
                c.Egresos.Add(egreso);
            }
            return c;
        }
        public static ContabilidadGenerico<T, U> operator +(ContabilidadGenerico<T, U> c, U ingreso)
        {
            if (ingreso is not null)
            {
                c.Ingresos.Add(ingreso);

            }
            return c;
        }
    }
}
