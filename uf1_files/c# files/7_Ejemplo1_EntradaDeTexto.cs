using System;

namespace daw_m03a_programming
{
    class Ejemplo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cómo te llamas?");
            //String nombre = Console.ReadLine();
            //Console.WriteLine("Hola {0}", nombre);
            Console.WriteLine("Hola {0}", Console.ReadLine());

            // Ambas líneas son equivalentes.
        }
    }
}

// OUTPUT
// Cómo te llamas?
// pepe
// Hola pepe