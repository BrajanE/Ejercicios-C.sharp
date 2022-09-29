using System;

namespace _5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            
            Random random = new Random();
            for(int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(-100,100);
                while (numeros[i] == 0)
                {
                    numeros[i] = random.Next();
                }
            }
            Console.WriteLine("Array completo");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"{i + 1} : {numeros[i]}");
            }
            Array.Sort(numeros, Program.OrdenDescendenteCriterio);
            //El metodo criterio es usado por el "Array"(evento)
            //si es negativo es descendente si es positivo es ascendente
            Console.WriteLine("\nArray de positivos ordenado descendente");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    Console.WriteLine($"{i + 1} : {numeros[i]}");
                }
            }
            Array.Sort(numeros);
            Console.WriteLine("\nArray de negativos ordenado ascendente");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.WriteLine($"{i + 1} : {numeros[i]}");
                }
            }

        }
        public static int OrdenDescendenteCriterio(int n1,int n2)
        {
            return n2 - n1;
        }
    }
}
