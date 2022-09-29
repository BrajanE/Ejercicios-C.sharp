using System;
using System.Text;

namespace _3_3_Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }
        static Estudiante()
        {
            random = new Random();
        }
        public void SetNotaPrimerParcial(int nota)
        {
            if(nota > 0)
            {
                notaPrimerParcial = nota;
            }
        }
        public void SetNotaSegundoParcial(int nota)
        {
            if (nota > 0)
            {
                notaSegundoParcial = nota;
            }
        }
        private float CalcularPromedio()
        {
            float promedio = (notaPrimerParcial + notaSegundoParcial) / 2;
            return promedio;
        }
        public double CalcularNotaFinal()
        {
            if(notaPrimerParcial > 3 && notaSegundoParcial > 3)
            {
                return random.Next(6 , 10); 
            }
            return -1;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos de alumno");
            sb.AppendLine($"{nombre} {apellido} {legajo}");
            sb.AppendLine($"Nota 1°P: {notaPrimerParcial}");
            sb.AppendLine($"Nota 2°P: {notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");

            if (CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"Nota final: {CalcularNotaFinal()}");
            }
            else sb.AppendLine("Alumno desaprobado");  
            return sb.ToString();
        }
       
    }
}
