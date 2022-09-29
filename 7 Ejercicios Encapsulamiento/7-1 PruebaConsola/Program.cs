using System;
using _7_1_Entidades;

namespace _7_1_PruebaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente(1, "Lautaro");
            Cliente c2 = new Cliente(2, "Mauricio");
            Cliente c3 = new Cliente(3, "Esteban");
            Negocio n1 = new Negocio("Kiosco-24");

            if (n1 + c1)
            {
                Console.WriteLine("Se agrego c1 a la cola");
            }
            //NO DEBERIA AGREGAR POR QUE YA ESTA EN LA COLA
            if (!(n1 + c1))
            {
                Console.WriteLine("Cliente c1 ya esta en la cola");
            }

            if (n1 + c2)
            {
                Console.WriteLine("Se agrego c2 a la cola");
            }

            if (n1 + c3)
            {
                Console.WriteLine("Se agrego c3 a la cola");
            }
            //NO DEBERIA AGREGAR POR QUE YA ESTA EN LA COLA
            if (!(n1 + c3))
            {
                Console.WriteLine("Cliente c3 ya esta en la cola");
            }
            
            Console.WriteLine("Clientes pendientes: {0}", n1.ClientesPendientes);
            //COMIENZA A ATENDER Y A CONTAR LOS CLIENTES
            while (~n1)
            {
                Console.WriteLine("Clientes pendientes: {0}", n1.ClientesPendientes);
            }
        }
    }
}
