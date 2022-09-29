using System;
using System.Text;

namespace _3_7_Entidades
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string[] historialVacunacion;

        public Mascota(string especie, string nombre, DateTime fechaDeNacimiento, string vacuna)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            historialVacunacion = new string[] {vacuna};
        }

        public void SetVacuna(string vacuna)
        {
            for (int i = 0; i < historialVacunacion.Length; i++)
            {
                if (historialVacunacion[i] is null)
                {
                    historialVacunacion[i] = vacuna;
                    break;
                }
            }
        }

        public string MostrarMascota()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos de compañero animal");
            sb.AppendLine($"{especie}");
            sb.AppendLine($"{nombre}");
            sb.AppendLine($"Fecha de nacimiento: {fechaDeNacimiento.ToString("dd/MM/yyyy")}");
            
                for (int i = 0; i < historialVacunacion.Length; i++)
                {
                    if (historialVacunacion[i] is not null)
                    {
                        sb.AppendLine($"{historialVacunacion[i]}");
                    }
                }
            
            return sb.ToString();
        }
    }
}
