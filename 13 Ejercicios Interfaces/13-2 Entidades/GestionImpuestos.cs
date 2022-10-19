using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2_Entidades
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            impuestosAduana = new List<IAduana>();
            impuestosAfip = new List<IAfip>();
        }
        public decimal CalcularTotalImpuestosAduana()
        {
            decimal montoTotal = 0;
            foreach (IAduana p in impuestosAduana)
            {
                montoTotal += p.Impuestos;
            }
            return montoTotal;
        }
        public decimal CalcularTotalImpuestosAfip()
        {
            decimal montoTotal = 0;
            foreach (IAfip p in impuestosAfip)
            {
                montoTotal += ((IAfip)p).Impuestos;
            }
            return montoTotal;
        }
        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete p in paquetes)
            {
                RegistrarImpuestos(p);
            }
        }
        public void RegistrarImpuestos(Paquete paquete)
        {
            impuestosAduana.Add(paquete);
            if(paquete.GetType() == typeof(PaquetePesado))
            {
                impuestosAfip.Add((IAfip)paquete);
            }
        }
    }
}
