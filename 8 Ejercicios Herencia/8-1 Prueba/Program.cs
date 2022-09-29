using System;
using _8_1_Entidades;

namespace _8_1_Prueba
{
    public class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre v1 = new VehiculoTerrestre(10,6,Colores.Negro);
            Console.WriteLine("Vehiculo X\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}",v1.CantidadRuedas,v1.CantidadPuertas,v1.Color);
            Console.WriteLine("--------------");
            
            Camion camioncito = new Camion(8, 2, Colores.Azul, 8, 5000);
            Console.WriteLine("Camion camioncito \nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nPeso Carga {4}", camioncito.CantidadRuedas, camioncito.CantidadPuertas, camioncito.Color, camioncito.CantidadMarchas, camioncito.PesoCarga);
           
            Console.WriteLine("--------------");
            Automovil autito = new Automovil(4, 5, Colores.Blanco, 5,  3);
            Console.WriteLine("Automovil autito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nCantidad Pasajeros: {4}", autito.CantidadRuedas, autito.CantidadPuertas, autito.Color, autito.CantidadMarchas, autito.CantidadPasajeros);
            
            Console.WriteLine("-----------");
            Moto motito = new Moto(2, 0, Colores.Rojo, 1000);
            Console.WriteLine("Moto motito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCilindrada: {3}", motito.CantidadRuedas, motito.CantidadPuertas, motito.Color, motito.Cilindrada);
        }
    }
}
