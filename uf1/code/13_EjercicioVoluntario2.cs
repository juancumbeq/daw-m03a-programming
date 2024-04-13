// Escribe un programa que declare un vector de números enteros tamaño 10, que pida los valores por teclado y que cuente los números pares que tiene.

using System;

namespace daw_m03a_programming
{
    class ExVoluntario2
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Introduzca un número: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Los números pares del array son: ");

            for (int j = 0; j < vector.Length; j++)
            {

                if ((vector[j] % 2 == 0))
                {
                    Console.Write($" {vector[j]} ");
                }
            }
        }
    }
}


// OUTPUT
// Introduzca un número: 2
// Introduzca un número: 3
// Introduzca un número: 4
// Introduzca un número: 5
// Introduzca un número: 6
// Introduzca un número: 7
// Introduzca un número: 8
// Introduzca un número: 9
// Introduzca un número: 10
// Los números pares del array son:  2  4  6  8  10