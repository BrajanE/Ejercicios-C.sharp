using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_Entidades
{
    public class EquipoFutbol : Equipo
    {
        public EquipoFutbol(string nombre) : base(nombre)
        {
        }

        public EquipoFutbol(string nombre, DateTime fechaCreacion) : base(nombre, fechaCreacion)
        {
        }
    }
}
