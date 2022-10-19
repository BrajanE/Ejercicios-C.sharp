using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(float tamanioMina)
        {
            this.tamanioMina = tamanioMina;
        }

        public ConsoleColor Color 
        {
            get { return ConsoleColor.Yellow; } 
            set => throw new NotImplementedException(); 
        }
        public float UnidadesDeEscritura 
        {
            get { return (float)Math.Round(tamanioMina, 2); }
            set { tamanioMina = value; } 
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escritura = new EscrituraWrapper(texto, Color);
            for (int i = 0; i < texto.Length; i++)
            {
                if (UnidadesDeEscritura > 0)
                {
                    UnidadesDeEscritura -= (float)0.1;
                }
                else UnidadesDeEscritura = 0;
            }
            return escritura;
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Esta utilizando un Lapiz:");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Nivel de mina: {UnidadesDeEscritura}");
            return sb.ToString();
        }
    }
}
