// El programa consiste en trabajar con una variable que contendrá una frase que se leerá por teclado.

// Se pide:
// - Imprimir por consola la variable en minúsculas sin espacios.
// - Imprimir por consola el total de consonantes de la variable.
// - Imprimir por consola la suma de todas las cifras numéricas que tiene la frase (cada cifra por separado)
// - Imprimir por consola solo las consonantes, en mayúsculas, y en el orden que las va encontrando en la misma línea. 

using System;

namespace daw_m03a_programming
{
    class EjercicioEnVivo1
    {
        static void Main(string[] args)
        {
            String[] nombres = new String[5];
            double[] salarios = new double[5];
            double max_salario = 0;
            int pos_max_salario = 0;

            Console.WriteLine("Ingrese los valores: ");
            Console.WriteLine();
            for (int i = 0; i < nombres.Length; i++)
            {

                // Inserción de datos
                Console.Write("Nombre empleado {0}: ", i + 1);
                nombres[i] = Console.ReadLine();

                Console.Write("Salario empleado {0}: ", i + 1);
                salarios[i] = double.Parse(Console.ReadLine());

                // En caso de que el salario sea 0
                while (salarios[i] == 0)
                {
                    Console.Write("El salario no puede ser 0, vuelva a insertar el valor: ");
                    salarios[i] = double.Parse(Console.ReadLine());
                }

                // Set up max_salario.
                if (salarios[i] > max_salario)
                {
                    max_salario = salarios[i];
                    pos_max_salario = i;
                }
                Console.WriteLine();
            }

            // Mostrar valores de los arrays
            for(int j=0; j < nombres.Length; j++)
            {
                Console.WriteLine("Nombre: {0}, Salario: {1}", nombres[j], salarios[j]);
            }
            Console.WriteLine();

            // Max salario
            Console.WriteLine("El salario máximo pertenece a {0}, con una cantidad de {1}", nombres[pos_max_salario], max_salario);
        }
    }
}


// OUTPUT
// Ingrese los valores:

// Nombre empleado 1: pepe1
// Salario empleado 1: 10

// Nombre empleado 2: pepe2
// Salario empleado 2: 20

// Nombre empleado 3: pepe3
// Salario empleado 3: 0
// El salario no puede ser 0, vuelva a insertar el valor: 0
// El salario no puede ser 0, vuelva a insertar el valor: 0
// El salario no puede ser 0, vuelva a insertar el valor: 30

// Nombre empleado 4: pepe4
// Salario empleado 4: 20

// Nombre empleado 5: pepe5
// Salario empleado 5: 50

// Nombre: pepe1, Salario: 10
// Nombre: pepe2, Salario: 20
// Nombre: pepe3, Salario: 30
// Nombre: pepe4, Salario: 20
// Nombre: pepe5, Salario: 50

// El salario máximo pertenece a pepe5, con una cantidad de 50