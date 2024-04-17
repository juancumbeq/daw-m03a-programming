using System;
using System.IO;

namespace daw_m03a_programming
{
    class EjercicioOpcionalPT1
    {

        static void anadirAlumno()
        {
            Console.WriteLine("Escribe el nombre del alumno: ");
            string alumno = Console.ReadLine();

            string ruta = @"/Users/juancumbe/Desktop/DEV/Projects/ILERNA Online subjects/daw-m03a-programming/uf3/code/01_alumnos.txt";
            FileStream fichero = new FileStream(ruta, FileMode.Append, FileAccess.Write);
            StreamWriter fe = new StreamWriter(fichero);

            fe.WriteLine(alumno);
            fe.Close();
            fichero.Close();
        }


        // Leer Fichero
        static void leerFichero()
        {
            string ruta = @"/Users/juancumbe/Desktop/DEV/Projects/ILERNA Online subjects/daw-m03a-programming/uf3/code/01_alumnos.txt";
            FileStream fichero = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader fl = new StreamReader(fichero);
            string linea;

            while((linea = fl.ReadLine()) != null)
            {
                Console.WriteLine(linea);
            }
            fl.Close();
            fichero.Close();
        }


        // Menu
        static int Menu()
        {
            Console.Write("Quieres leer o añadir? ");
            string teclado = Console.ReadLine().ToLower();
            if (teclado == "leer")
            {
                return 0;
            }
            else if(teclado == "añadir")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }



        // Main
        static void Main(string[] args)
        {
            int opcion;
            while(true)
            {
                opcion = Menu();
                if(opcion == 0)
                {
                    leerFichero();
                }
                else if(opcion == 1)
                {
                    anadirAlumno();
                }
                else
                {
                    break;
                }
            }
        }
    }
}


// OUTPUT
// Quieres leer o añadir? añadir
// Escribe el nombre del alumno:
// pepe
// Quieres leer o añadir? añadir
// Escribe el nombre del alumno:
// jaime
// Quieres leer o añadir? añadir
// Escribe el nombre del alumno:
// juan
// Quieres leer o añadir? añadir
// Escribe el nombre del alumno:
// pepe3
// Quieres leer o añadir? leer
// pepe
// jaime
// juan
// pepe3
// Quieres leer o añadir? c