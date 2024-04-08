using System;

namespace daw_m03a_programming
{
    class ReadLine
    {
        static void Main(string[] args)
        {
            // Console.Write("Escribe un número...");
            // String op1 = Console.ReadLine();

            // Console.Write("Escribe otro número...");
            // String op2 = Console.ReadLine();

            // Console.WriteLine("La suma es {0}", op1 + op2);

            // Los valores de entrada los recoge siempre en formato string. 
            // El resultado de este código sería la concatenación de dos números en formato string


            Console.Write("Escribe un número...");
            int op1 = Int32.Parse(Console.ReadLine());

            Console.Write("Escribe otro número...");
            int op2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe otro número...");
            int op3 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma es {0}", op1 + op2 + op3);

            // Es necesario parsear los valores de entrada para que sean tratados de manera correcta.
            // Los métodos de parseo son equivalentes.
        }
    }
}

// OUTPUT
// Escribe un número...10
// Escribe otro número...10
// Escribe otro número...10
// La suma es 30