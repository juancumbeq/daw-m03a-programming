using System;

namespace daw_m03a_programming
{
    class EjemploProgramacionModular
    {
        // Generator
        static int generator()
        {
            int num = 0;
            Random aleatorio = new Random();
            num = aleatorio.Next(10, 51);
            return num;
        }

        // Printer
        static void printVector(int[] vec)
        {
            Console.WriteLine("Vector resultante: \n");
            for (int i = 0; i < vec.Length; i++)
            {
                Console.Write(vec[i] + " ");
            }
        }


        // Main
        static void Main(string[] args)
        {
            int[] vector = new int[10];

            // Filling the vector
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = generator();
            }

            // Printing the vector
            printVector(vector);
        }
    }
}


// OUTPUT
// Vector resultante:

// 46 29 22 48 40 10 29 27 43 39