using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_Entidades
{
    public class SobreSobrescrito : Sobrescrito
    {
        public override string MiPropiedad
        {
            get { return miAtributo; }
        }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
