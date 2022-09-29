using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_5_Entidades
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        private AutoF1()
        {
            enCompetencia = false;
            cantidadCombustible = 0;
            vueltasRestantes = 0;
        }

        public AutoF1(string escuderia, short numero)
            :this()
        {
            this.escuderia = escuderia;
            this.numero = numero;     
        }
        public void SetCantCombustible(short cantCombustible)
        {
            cantidadCombustible = cantCombustible;
        }
        public void SetCompetencia(bool opcion)
        {
            enCompetencia = opcion;
        }
        public void SetVueltasRestantes(short vueltas)
        {
            vueltasRestantes = vueltas;
        }

        public short GetCantCombustible()
        {
            return cantidadCombustible;
        }
        public bool GetEnCompetencia()
        {
            return enCompetencia;
        }
        public short GetVueltasRestantes()
        {
            return vueltasRestantes;
        }
        public static bool operator ==(AutoF1 a1,AutoF1 a2)
        {
            if((a1.escuderia == a2.escuderia) && (a1.numero == a2.numero))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Auto: {escuderia}");
            sb.AppendLine($"Numero: {numero}");
            sb.AppendLine($"Cantidad combustible: {GetCantCombustible()}");
            sb.AppendLine($"Vueltas restantes: {GetVueltasRestantes()}");
            sb.AppendLine($"En competencia?: {GetEnCompetencia()}");
            return sb.ToString();
        }
       
    }
}
