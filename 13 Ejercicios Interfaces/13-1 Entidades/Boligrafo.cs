using System;
using System.Text;

namespace _13_1_Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(float unidadesDeEscritura, ConsoleColor color)
        {
            Color = color;
            UnidadesDeEscritura = unidadesDeEscritura;
        }

        public ConsoleColor Color
        {
            get
            {
                return colorTinta;
            }
            set
            {
                colorTinta = value;
            }
        }
        public float UnidadesDeEscritura
        {
            get { return (float)Math.Round(tinta, 2);}
            set { tinta = value; }
        }
        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escritura = new EscrituraWrapper(texto,Color);
            for (int i = 0; i < texto.Length; i++)
            {
                if (UnidadesDeEscritura > 0)
                {
                    UnidadesDeEscritura -= (float)0.3;
                }
                else UnidadesDeEscritura = 0;
            }
            return escritura;
        }
        public bool Recargar(int unidades)
        {
            UnidadesDeEscritura += unidades;
            return true;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Esta utilizando un Boligrafo:");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Nivel de tinta: {UnidadesDeEscritura}");
            return sb.ToString();
        }
    }
}
