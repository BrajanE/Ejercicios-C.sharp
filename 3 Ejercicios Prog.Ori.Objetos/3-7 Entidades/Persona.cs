using System;
using System.Text;

namespace _3_7_Entidades
{
    public class Persona
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private int telefono;
        private Mascota[] mascotas;

        public Persona(string domicilio, string nombre, string apellido, int telefono)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            mascotas = new Mascota[5];
        }
        public void SetMascota(Mascota mascota)
        {
            for (int i = 0; i < mascotas.Length; i++)
            {
                if (mascotas[i] is null)
                {
                    mascotas[i] = mascota;                 
                    break;
                }
            }
        }

        public string MostrarDatosClientes()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos de cliente");
            sb.AppendLine($"{nombre}");
            sb.AppendLine($"{apellido}");
            sb.AppendLine($"{domicilio}");
            
            for(int i = 0; i < mascotas.Length; i++)
            {
                if (mascotas[i] is not null)
                {
                    sb.AppendLine($"{mascotas[i].MostrarMascota()}");
                }
            }
            return sb.ToString();
        }

    }
}
