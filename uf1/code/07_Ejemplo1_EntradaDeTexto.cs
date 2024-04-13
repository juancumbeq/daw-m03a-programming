// Crea un programa que muestre la pregunta "¿Cómo te llamas? Y a continuación espere a que el usuario teclee su nombre, guardando la entrada de teclado en una variable. Por último, debe mostrar el saludo !Hola, **nombre**!

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