using System;

namespace daw_m03a_programming
{
    class EjemploProgramacionModular
    {

        // Suma
        static int suma(int v1, int v2)
        {
            return v1 + v2;
        }

        // Resta
        static int resta(int v1, int v2)
        {
            return v1 - v2;
        }

        // Mutliplicación
        static int multi(int v1, int v2)
        {
            return v1 * v2;
        }

        // División
        static int div(int v1, int v2)
        {
            return v1 / v2;
        }

        // Main
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            Console.WriteLine("Introduce un número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro número: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma es {0}", suma(a, b));
            Console.WriteLine("La resta es {0}", resta(a, b));
            Console.WriteLine("La multiplicación es {0}", multi(a, b));
            Console.WriteLine("La división es {0}", div(a, b));
        }
    }
}


// OUTPUT
// Introduce un número:
// 1
// Introduce otro número:
// 2
// La suma es 3
// La resta es -1
// La multiplicación es 2
// La división es 0