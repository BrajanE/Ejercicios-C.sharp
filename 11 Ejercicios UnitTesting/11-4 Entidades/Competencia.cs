using System;
using System.Collections.Generic;
using System.Text;

namespace _11_4_Entidades
{
    public enum ETipoCompetencia
    {
        F1, MotoCross
    }
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private ETipoCompetencia tipo;

        private Competencia()
        {
            this.Competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, ETipoCompetencia tipo) : this()
        {
            CantidadCompetidores = cantidadCompetidores;
            CantidadVueltas = cantidadVueltas;
            Tipo = tipo;
        }

        public short CantidadCompetidores { get => cantidadCompetidores; set => cantidadCompetidores = value; }
        public short CantidadVueltas { get => cantidadVueltas; set => cantidadVueltas = value; }
        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.Competidores[i];
            }
        }
        public ETipoCompetencia Tipo { get => tipo; set => tipo = value; }
        public List<VehiculoDeCarrera> Competidores { get => competidores; set => competidores = value; }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*** Rally BEmoreno *** ");
            sb.AppendLine($"Cupos para competidores: {CantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {CantidadVueltas}");
            sb.AppendLine($"Datos de competidores:\n");
            foreach (VehiculoDeCarrera v in Competidores)
            {
                //verificamos el tipo de vehiculo
                if (v.GetType() == typeof(AutoF1))
                {
                    sb.AppendLine(((AutoF1)v).MostrarDatos());
                }
                else if (v.GetType() == typeof(MotoCross))
                {
                    sb.AppendLine(((MotoCross)v).MostrarDatos());
                }
            }
            return sb.ToString();
        }
        public static bool operator +(Competencia c, VehiculoDeCarrera vNuevo)
        {
         //COMENTADO PORQUE SI SE CONTROLA LA EXCEPCION EL TESTING NO LO CUENTA  
            //try
            //{
                
                if (c.CantidadCompetidores > c.Competidores.Count && c!=vNuevo)
                    {
                        vNuevo.EnCompetencia = true;
                        vNuevo.VueltasRestantes = c.CantidadVueltas;
                        Random rdn = new Random();
                        vNuevo.CantidadCombustible = (short)rdn.Next(15, 100);
                        c.Competidores.Add(vNuevo);
                        return true;
                    }               
            //}
            //catch (CompetenciaNoDisponibleException ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            return false;
        }
        public static bool operator -(Competencia c, VehiculoDeCarrera vNuevo)
        {
            if (c.CantidadCompetidores > c.Competidores.Count)
            {
                foreach (VehiculoDeCarrera v in c.Competidores)
                {
                    if (v == vNuevo)
                    {
                        vNuevo.EnCompetencia = false;
                        vNuevo.VueltasRestantes = 0;
                        c.Competidores.Remove(vNuevo);
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator ==(Competencia c, VehiculoDeCarrera vNuevo)
        {
            try
            {
                ComprobacionCompetencia(c, vNuevo);
                if (c.Competidores.Count > 0)
                {
                    foreach (VehiculoDeCarrera v in c.Competidores)
                    {
                        if (v == vNuevo)
                        {
                            return true;
                        }

                    }
                }


            }
            catch (CompetenciaNoDisponibleException ex)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "Operador +", ex);
            }
            return false;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera vNuevo)
        {

            return !(c == vNuevo);

        }

        public static void ComprobacionCompetencia(Competencia c, VehiculoDeCarrera vNuevo)
        {
            if (!((c.Tipo == ETipoCompetencia.F1 && vNuevo.GetType() == typeof(AutoF1)) || (c.Tipo == ETipoCompetencia.MotoCross && vNuevo.GetType() == typeof(MotoCross))))
            {
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "Operador ==");
            }
        }
    }
}
