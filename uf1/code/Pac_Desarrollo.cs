// El programa consiste en trabajar con una variable que contendrá una frase que se leerá por teclado.

// Se pide:
// - Imprimir por consola la variable en minúsculas sin espacios.
// - Imprimir por consola el total de consonantes de la variable.
// - Imprimir por consola la suma de todas las cifras numéricas que tiene la frase (cada cifra por separado)
// - Imprimir por consola solo las consonantes, en mayúsculas, y en el orden que las va encontrando en la misma línea. 

using System;

namespace daw_m03a_programming
{
    class Pac_Desarrollo
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Introduce una frase: ");
            // String frase = Console.ReadLine();

            String frase = "Ilerna Online Programación A 2º Semestre 22-23";
            char[] consonantes = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            int cont_consonantes = 0;
            int suma_cifras = 0;
            int cifra;


            // - Imprimir por consola la variable en minúsculas sin espacios.
            foreach (char letra in frase.ToLower())
            {
                if (letra != ' ')
                {
                    Console.Write("{0}", letra);
                }
            }
            Console.WriteLine();


            // - Imprimir por consola el total de consonantes de la variable.
            foreach(char letra in frase.ToLower())
            {
                if (Array.IndexOf(consonantes, letra) != -1) // IndexOf busca la primera ocurrencia en el array indicado.
                {
                    cont_consonantes++;
                }
            }
            Console.WriteLine("{0}", cont_consonantes);



            // - Imprimir por consola la suma de todas las cifras numéricas que tiene la frase (cada cifra por separado)
            foreach(char ch in frase)
            {
                if(int.TryParse(ch.ToString(), out cifra)) // TryParse() espera un string no un char.
                {
                    suma_cifras += cifra;
                }
            }
            Console.WriteLine("{0}", suma_cifras);


            // - Imprimir por consola solo las consonantes, en mayúsculas, y en el orden que las va encontrando en la misma línea.
            foreach(char ch in frase)
            {
                if(Array.IndexOf(consonantes, char.ToLower(ch)) != -1)
                {
                    Console.Write(char.ToUpper(ch));
                }
            }
        }
    }
}


// OUTPUT
// ilernaonlineprogramacióna2ºsemestre22 - 23
// 18
// 11
// LRNNLNPRGRMCNSMSTR