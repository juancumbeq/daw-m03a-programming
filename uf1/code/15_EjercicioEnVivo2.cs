// El programa consiste en trabajar con una variable que contendrá una frase que se leerá por teclado.

// Se pide:
// - Imprimir por consola la variable en minúsculas sin espacios.
// - Imprimir por consola el total de consonantes de la variable.
// - Imprimir por consola la suma de todas las cifras numéricas que tiene la frase (cada cifra por separado)
// - Imprimir por consola solo las consonantes, en mayúsculas, y en el orden que las va encontrando en la misma línea. 

using System;

namespace daw_m03a_programming
{
    class EjericicioEnVivo2
    {
        static void Main(string[] args)
        {
            // Declaración de matriz
            int[,] matriz = new int[2,3];

            // Inicialización de matriz
            Random aleatorio = new Random();
            for(int i= 0; i < matriz.GetLength(0); i++) // GetLength da el # de rows
            {
                for(int j= 0; j < matriz.GetLength(1); j++) // GetLength da el # de columns
                {
                    matriz[i,j] = aleatorio.Next(0, 10);
                    Console.Write(matriz[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}


// OUTPUT
