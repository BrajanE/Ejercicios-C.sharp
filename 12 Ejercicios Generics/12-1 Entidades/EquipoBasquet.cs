using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_Entidades
{
    public class EquipoBasquet : Equipo
    {
        public EquipoBasquet(string nombre) : base(nombre)
        {
        }

        public EquipoBasquet(string nombre, DateTime fechaCreacion) : base(nombre, fechaCreacion)
        {
        }
    }
}
