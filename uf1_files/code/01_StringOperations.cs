using System;

namespace dawm03a_programming
{
    class StringOperations
    {
        static void Main(string[] args)
        {
            String nombre = "Programación";
            Console.WriteLine(nombre.Trim());
            Console.WriteLine("La longitud es de " + nombre.Length);
            Console.WriteLine(nombre.ToUpper());
            Console.WriteLine(nombre.Substring(2, 4));
            if (nombre.Contains("ogra"))
            {
                Console.WriteLine("true");
            };
        }
    }
}

// OUTPUT:
// La longitud es de 12
// PROGRAMACIÓN
// ogra
// true