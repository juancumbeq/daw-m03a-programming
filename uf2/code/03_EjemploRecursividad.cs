using System;

namespace daw_m03a_programming
{
    class EjemploRecursividad
    {
        // No recursivo
        static int noRecursivo(int n)
        {
            int num = 1;
            for (int i = 0; i > 0; i--)
            {
                num = num * i;
            }
            return num;
        }

        // Recursivo
        static int recursivo(int n)
        {
            int en_proceso;
            if (n == 1)
            {
                Console.WriteLine("Estoy en un caso base porque n vale {0}", n);
                return 1;
            }
            else
            {
                Console.WriteLine("Estoy en un caso general porque n vale {0}", n);
                en_proceso = recursivo(n - 1) * n;
                Console.WriteLine("Termino el caso general con n = {0} y en_proceso = {1}", n, en_proceso);
                return en_proceso;
            }
        }

        // Main
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número: ");
            int num = int.Parse(Console.ReadLine());

            //Console.WriteLine("Con el método NO recursivo el resultado es {0}", noRecursivo(num));

            Console.WriteLine("Con el método recursivo el resultado es: {0}", recursivo(num));
        }
    }
}


// OUTPUT
// Escribe un número:
// 5
// Estoy en un caso general porque n vale 5
// Estoy en un caso general porque n vale 4
// Estoy en un caso general porque n vale 3
// Estoy en un caso general porque n vale 2
// Estoy en un caso base porque n vale 1
// Termino el caso general con n = 2 y en_proceso = 2
// Termino el caso general con n = 3 y en_proceso = 6
// Termino el caso general con n = 4 y en_proceso = 24
// Termino el caso general con n = 5 y en_proceso = 120
// Con el método recursivo el resultado es: 120