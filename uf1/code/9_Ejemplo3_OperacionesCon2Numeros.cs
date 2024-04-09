using System;

namespace daw_m03a_programming
{
    class Ejemplo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro número:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("SUMA: {0} + {1} = {2}", a, b, a+b);
            Console.WriteLine("RESTA: {0} - {1} = {2}", a, b, a-b);
            Console.WriteLine("MULTIPLICACIÓN: {0} * {1} = {2}", a, b, a*b);
            Console.WriteLine("DIVISÓN: {0} / {1} = {2}", a, b, a/b);
        }
    }
}

// OUTPUT
// Introduce un número:
// 4
// Introduce otro número:
// 6
// SUMA: 4 + 6 = 10
// RESTA: 4 - 6 = -2
// MULTIPLICACIÓN: 4 * 6 = 24
// DIVISÓN: 4 / 6 = 0