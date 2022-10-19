using System;
using System.Collections.Generic;

namespace _13_1_Entidades
{
    public class CartucheraSimple
    {
        List<Boligrafo> listaBoligrafo;
        List<Lapiz> listaLapiz;

        public CartucheraSimple()
        {
            this.ListaBoligrafo = new List<Boligrafo>();
            this.ListaLapiz = new List<Lapiz>();

        }

        public List<Boligrafo> ListaBoligrafo { get => listaBoligrafo; set => listaBoligrafo = value; }
        public List<Lapiz> ListaLapiz { get => listaLapiz; set => listaLapiz = value; }

        public bool RecorrerElementos()
        {
            int control = 0;
            foreach (Boligrafo accion in ListaBoligrafo)
            {
                if (accion.UnidadesDeEscritura > 0)
                {
                    accion.UnidadesDeEscritura -= 1;
                    if (accion.UnidadesDeEscritura <= 0)
                    {
                        accion.Recargar(20);
                    }
                    control++;
                }
            }
            foreach (Lapiz accion in ListaLapiz)
            {
                if (accion.UnidadesDeEscritura > 0)
                {
                    accion.UnidadesDeEscritura -= 1;
                    if (accion.UnidadesDeEscritura <= 0)
                    {
                        accion.Recargar(20);
                    }
                    control++;
                }
            }
            if (control == ListaBoligrafo.Count + ListaLapiz.Count)
            {
                Console.WriteLine("**Cartuchera Simple**");
                Console.WriteLine($"Cantidad de objetos usados: {control}");
                return true;
            }
            else return false;
        }
    }
}
