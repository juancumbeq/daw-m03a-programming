using System;

namespace daw_m03a_programming
{
    class Ejemplo3
    {
        static void Main(string[] args)
        {
            String finalizar;

            do{
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

              Console.Write("Si desea terminar las operaciones escriba \"finalizar\": ");
              finalizar = Console.ReadLine();
              Console.WriteLine();

            } while(!finalizar.Contains("finalizar"));
        }
    }
}

// OUTPUT
// Introduce un número: 5
// Introduce otro número: 6
// Qué operación deseada realizar?: suma
// SUMA: 5 + 6 = 11
// Si desea terminar las operaciones escriba "finalizar": no

// Introduce un número: 5
// Introduce otro número: 6+
// Qué operación deseada realizar?: resta
// RESTA: 5 - 6 = -1
// Si desea terminar las operaciones escriba "finalizar": finalizar