using System;
using System.Collections.Generic;

namespace _6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listEnteros = new List<int>();
            Queue<int> queueEnteros = new Queue<int>();
            Stack<int> stackEnteros = new Stack<int>();
            Random rdm = new Random();

            //CARGA DE LISTA, COLA Y PILA

            for (int i = 0; i < 20; i++)
            {
                listEnteros.Add(rdm.Next(-100, 100));
                queueEnteros.Enqueue(rdm.Next(-100, 100));
                stackEnteros.Push(rdm.Next(-100, 100));
            }

            //MUESTRA DE COLECCIONES

            int index = 1;
            Console.WriteLine("\n**Lista Enteros**\n");
            foreach (int i in listEnteros)
            {
                Console.WriteLine($"{index} - {i}");
                index++;
            }
            index = 1;
            Console.WriteLine("\n**Cola Enteros**\n");
            foreach (int i in queueEnteros)
            {
                Console.WriteLine($"{index} - {i}");
                index++;
            }
            index = 1;
            Console.WriteLine("\n**Pila Enteros**\n");
            foreach (int i in stackEnteros)
            {
                Console.WriteLine($"{index} - {i}");
                index++;
            }

            // ORDEN Y MUESTRA DE POSITIVOS

            listEnteros.Sort(OrdenDescendenteCriterio);
            Console.WriteLine("\n**Lista positivos**\n");
            index = 1;
            foreach (int i in listEnteros)
            {             
                if (i > 0)
                {
                    Console.WriteLine($"{index} - {i}");
                }
                index++;
            }
            Console.WriteLine("\n**Cola positivos**\n");
            index = 1;
            foreach (int i in queueEnteros)
            {
                if (i > 0)
                {
                    Console.WriteLine($"{index} - {i}");
                }
                index++;
            }
            Console.WriteLine("\n**Pila positivos**\n");
            index = 1;
            foreach (int i in stackEnteros)
            {
                if (i > 0)
                {
                    Console.WriteLine($"{index} - {i}");
                }
                index++;
            }
            index = 1;
            Console.WriteLine("\n**Lista negativos ordenado ascendentemente**\n");
            listEnteros.Sort();
            foreach (int i in listEnteros)
            {
                if (i < 0)
                {
                    Console.WriteLine($"{index} - {i}");
                }
                index++;
            }
            Console.WriteLine("\n**Cola negativos**\n");
            index = 1;
            foreach (int i in queueEnteros)
            {
                if (i < 0)
                {
                    Console.WriteLine($"{index} - {i}");
                }
                index++;
            }
            Console.WriteLine("\n**Pila negativos**\n");
            index = 1;
            foreach (int i in stackEnteros)
            {
                if (i < 0)
                {
                    Console.WriteLine($"{index} - {i}");
                }
                index++;
            }
        }
        public static int OrdenDescendenteCriterio(int n1, int n2)
        {
            return n2 - n1;
        }
    }
}
