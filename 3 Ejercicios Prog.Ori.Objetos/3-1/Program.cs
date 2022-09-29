using System;
using Entidades;

namespace _3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcionStr;
            int opcion;
            Cuenta cuenta = new Cuenta("Brajan Estrada", 1000);

            do
            {
                Console.WriteLine("Bienvenido a BancoMoreno");
                Console.WriteLine("\tElija una opcion:");
                Console.WriteLine("\t-1-Ingresar Dinero");
                Console.WriteLine("\t-2-Retirar Dinero");
                Console.WriteLine("\t-3-Mostrar datos de cuenta");
                Console.WriteLine("\t-4-SALIR\n");

                opcionStr = Console.ReadLine();
                int.TryParse(opcionStr, out opcion);
                
                decimal cantidad;
                string cantStr;

                if (opcion > 0 && opcion < 4)
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese cantidad a ingresar: ");
                            cantStr = Console.ReadLine();
                            if (decimal.TryParse(cantStr, out cantidad)&&cantidad>0)
                            {
                                cuenta.Ingresar(cantidad);
                                Console.WriteLine($"Se ingresaron {cantidad}\n");
                               
                            }
                            else
                            {
                                Console.WriteLine("Valor invalido");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Ingrese cantidad a retirar: ");
                            cantStr = Console.ReadLine();
                            if (decimal.TryParse(cantStr, out cantidad) && cantidad > 0)
                            {
                                cuenta.Retirar(cantidad);
                                Console.WriteLine($"Se retiraron {cantidad}\n");
                            }
                            else
                            {
                                Console.WriteLine("Valor invalido");
                            }
                            break;

                        case 3:
                            Console.WriteLine(cuenta.Mostrar());
                            
                            break;

                    }
                }
            } while (opcion > 0 && opcion < 4);
            

        }
    }
}
