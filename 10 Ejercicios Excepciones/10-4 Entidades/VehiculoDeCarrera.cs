using System;
using System.Text;

namespace _10_4_Entidades
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            Escuderia = escuderia;
            Numero = numero;
        }

        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public string Escuderia { get => escuderia; set => escuderia = value; }
        public short Numero { get => numero; set => numero = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\t**Vehiculo de Carrera**");
            sb.AppendLine($"Escuderia: {Escuderia}");
            sb.AppendLine($"Numero: {Numero}");
            sb.AppendLine($"Cant. Combustible: {CantidadCombustible}");
            sb.AppendLine($"Estado: {EnCompetencia}");
            sb.AppendLine($"Vueltas Restantes: {VueltasRestantes}");
            return sb.ToString();
        }
    }
}
