using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_Entidades
{
    public class CartucheraMultiuso
    {
        List<IAcciones> acciones ;

        public CartucheraMultiuso()
        {
            this.Acciones = new List<IAcciones>();
        }

        public List<IAcciones> Acciones { get => acciones; set => acciones = value; }

        public bool RecorrerElementos()
        {
            int control = 0;
            foreach (IAcciones accion in Acciones)
            {
                if (accion.UnidadesDeEscritura > 0)
                {


                    accion.UnidadesDeEscritura -= 1;
                    if (accion.UnidadesDeEscritura <= 0)
                    {
                        accion.Recargar(20);
                    }
                    control++;
                }
            }
            if (control == Acciones.Count)
            {
                Console.WriteLine("**Cartuchera Multiuso**");
                Console.WriteLine($"Cantidad de objetos usados: {control}");
                return true;
            }
            else return false;
        }
    }
}
