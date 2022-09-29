using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _7_1_Entidades
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2
        };
        private static int numeroActual;
        private Puesto puesto;

        private PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }  
        public static int NumeroActual
        {
            get {
                numeroActual++;
                return numeroActual; }
        }
        public bool Atender(Cliente cl)
        {
            if(cl is not null)
            {
                Thread.Sleep(3000);
                return true;
            }
            return false;
        }
    }
}
