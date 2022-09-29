using System;
using System.Collections.Generic;
using System.Text;

namespace _6_5_Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> listCompetidores;

        private Competencia()
        {
            listCompetidores = new List<AutoF1>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas)
            : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de competidores: {cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {cantidadVueltas}");
            sb.AppendLine($"Datos de competidores:\n");
            foreach (AutoF1 auto in listCompetidores)
            {
                sb.AppendLine(auto.MostrarDatos());
            }
            return sb.ToString();
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            if (c.cantidadCompetidores > c.listCompetidores.Count)
            {
                foreach (AutoF1 auto in c.listCompetidores)
                {
                    if (auto == a)
                    {
                        return false;
                    }
                }
                a.SetCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                Random rdn = new Random();
                a.SetCantCombustible((short)rdn.Next(15, 100));
                c.listCompetidores.Add(a);
                return true;
            }
            return false;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c.cantidadCompetidores > c.listCompetidores.Count)
            {
                foreach (AutoF1 auto in c.listCompetidores)
                {
                    if (auto == a)
                    {
                        a.SetCompetencia(false);
                        a.SetVueltasRestantes(0);
                        c.listCompetidores.Remove(a);
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 auto in c.listCompetidores)
            {
                return (auto == a);
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {

            return !(c == a);

        }

    }
}
