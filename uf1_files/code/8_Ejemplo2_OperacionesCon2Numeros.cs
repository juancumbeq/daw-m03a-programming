using System;

namespace daw_m03a_programming
{
    class Ejemplo2
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 6;
            Console.WriteLine("SUMA: {0} + {1} = {2}", a, b, a+b);
            Console.WriteLine("RESTA: {0} - {1} = {2}", a, b, a-b);
            Console.WriteLine("MULTIPLICACIÓN: {0} * {1} = {2}", a, b, a*b);
            Console.WriteLine("DIVISÓN: {0} / {1} = {2}", a, b, a/b);
        }
    }
}

// OUTPUT
// SUMA: 4 + 6 = 10
// RESTA: 4 - 6 = -2
// MULTIPLICACIÓN: 4 * 6 = 24
// DIVISÓN: 4 / 6 = 0