using System;

namespace daw_m03a_programming
{
    class NumberOperations
    {
        static void Main(string[] args)
        {
            int op1 = 65;
            int op2 = 21;
            int resto = op1 % op2;
            Console.WriteLine("El resto de dividir {0} entre {1} es ...{2}", op1, op2, resto);
            // Console.WriteLine($"El resto de dividir {op1} entre {op2} es ...{resto}");
            // Mediante el símbolo "$" podemos incluir variable directamente
        }
    }
}

// OUTPUT
// El resto de dividir 65 entre 21 es ...2