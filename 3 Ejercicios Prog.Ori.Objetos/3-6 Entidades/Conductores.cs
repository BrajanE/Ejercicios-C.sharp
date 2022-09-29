using System;
using System.Collections.Generic;
using System.Text;

namespace _3_6_Entidades
{
    public class Conductores
    {
        private string nombre;
        private int[] kmPorDia;
        private static Random rnd;


        public Conductores(string nombre)
        {
            this.nombre = nombre;  
            this.kmPorDia = new int[7];
        }
        static Conductores()
        {
            rnd = new Random();
        }
        public void SetKmPorDia()
        {
            for(int i = 0; i < kmPorDia.Length; i++)
            {
                kmPorDia[i] = rnd.Next(0,1000);
            }
        }
        public int GetKm(int posicion)
        {
            return kmPorDia[posicion];
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**Datos conductor**");           
            sb.AppendLine($"{GetNombre()}");
            sb.AppendLine("Kilometros por dia de la semana:");
            for(int i = 0; i< kmPorDia.Length; i++)
            {
                sb.AppendLine($"Dia {i+1}: {kmPorDia[i]}");
            }
            return sb.ToString();
        }
        public int SumaKm()
        {
            int sumatoria=0;
            foreach(int km in kmPorDia)
            {
                sumatoria += km;
            }
            return sumatoria;
        }


    }
}
