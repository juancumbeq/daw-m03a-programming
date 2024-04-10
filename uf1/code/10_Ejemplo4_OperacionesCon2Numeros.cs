using System;

namespace daw_m03a_programming
{
    class Ejemplo3
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Introduce otro número: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Qué operación deseada realizar?: ");
            String op = Console.ReadLine().ToLower();

            if(op.Contains("suma")){
              Console.WriteLine("SUMA: {0} + {1} = {2}", a, b, a+b);
            } else if(op.Contains("resta")){
              Console.WriteLine("RESTA: {0} - {1} = {2}", a, b, a-b);
            } else if(op.Contains("multiplicación")){
              Console.WriteLine("MULTIPLICACIÓN: {0} * {1} = {2}", a, b, a*b);
            } else if(op.Contains("división")){
              Console.WriteLine("DIVISÓN: {0} / {1} = {2}", a, b, a/b);
            }
        }
    }
}

// OUTPUT
// Introduce un número:5
// Introduce otro número: 6
// Qué operación deseada realizar?: división
// DIVISÓN: 5 / 6 = 0.833333333333333