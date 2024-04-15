// Realiza un programa que rellene aleatoriamente un matriz de 2x3 (2 filas y 3 columnas). El programa debe mostrarla en forma de tabla después de que se haya rellenado.

// A tener en cuenta:
//     - Los números deben ser de tipo int.
//     - Tendrás que utilizar la clase Random.

// Funcionalidad extra: muestra junto a cada fila y columna el resultado de la suma de todos los números que la componen.

using System;

namespace daw_m03a_programming
{
    class EjericicioEnVivo2
    {
        static void Main(string[] args)
        {
            // Declaración de matriz
            int[,] matriz = new int[2, 3];

            // Array para almacenar los valores de la última columna
            int[] final_col = new int[matriz.GetLength(0)];

            // Variables para almacenar las sumas de las filas y columnas
            int suma_rows = 0;
            int suma_columnas = 0;


            // Inicialización de objeto random
            Random aleatorio = new Random();

            // Primer bucle
            for (int i = 0; i < matriz.GetLength(0); i++) // GetLength da el # de rows
            {
                for (int j = 0; j < matriz.GetLength(1); j++) // GetLength da el # de columns
                {
                    matriz[i, j] = aleatorio.Next(0, 20);
                    suma_rows += matriz[i, j];
                    Console.Write(matriz[i, j] + "\t");
                }
                // Mostramos la suma de los valores del row
                Console.Write(suma_rows);

                // Guardamos las sumas en un array externo
                final_col[i] = suma_rows;

                suma_rows = 0; // Reset suma
                Console.WriteLine();
            }

            // Segundo bucle
            for(int i = 0; i < matriz.GetLength(1); i++) // Recorremos las columnas
            {
                for (int j = 0; j < matriz.GetLength(0); j++) // Recorremos las filas
                {
                    suma_columnas += matriz[j, i]; // Sumamos los valores de la matriz
                }
                // Mostramos la suma de los valores de las cols
                Console.Write(suma_columnas + "\t");
                suma_columnas = 0; // Reset suma
            }

            // Tercer bucle para recorrer los valores de la última columna que no son de array
            for(int i = 0; i < final_col.GetLength(0); i++)
            {
                suma_columnas += final_col[i];
            }
            Console.WriteLine(suma_columnas);
        }
    }
}


// OUTPUT
// 3       9       4       16
// 5       16      17      38
// 8       25      21      54





// Solución

using System;
namespace Videotutoria
{
    class Program
    {
        static void Main()
        {
            int[,] matriz = new int[2,3];
            Random aleatorio = new Random();

            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i,j] = aleatorio.Next(11);
                }
            }

            int suma = 0;

            for(int f = 0; f < matriz.GetLength(0); f++)
            {
                for(int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f,c] + "\t");
                    suma += matriz[f,c];
                }
                Console.WriteLine("|\t{0}", suma);
                suma = 0;
            }

            int sumaTotal = 0;
            Console.WriteLine("-------------------");
            
            for(int c = 0; c < matriz.GetLength(1); c++)
            {
                for(int f = 0; f < matriz.GetLength(0); f++)
                {
                    suma += matriz[f,c];
                }
                Console.Write("{0}\t", suma);
                sumaTotal += suma;
                suma = 0;
            }
            Console.WriteLine("|\t{0}", sumaTotal);
        }
    }
}