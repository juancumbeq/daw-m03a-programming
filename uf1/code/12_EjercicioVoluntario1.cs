// Desarrolla un algoritmo que permita determinar a partir de un númera de días ingresado por pantalla (teclado), cuántos años, meses, semanas, y días son. Supón que todos los meses son de 30 días.

using System;

namespace daw_m03a_programming
{
    class ExVoluntario1
    {
        static void Main(string[] args)
        {
            int years;
            int months;
            int weeks;
            int days;
            
            Console.Write("Introduce un número de días: ");
            int num = int.Parse(Console.ReadLine());
            
            years = num / 365;
            months = (num % 365) / 30;
            weeks = ((num % 365) % 30) / 7;
            days = (((num % 365) % 30) % 7);
            
            if (years > 0)
            {
                Console.WriteLine($"AÑOS: {years}");
            }
            if(months > 0)
            {
                Console.WriteLine($"MESES: {months}");
            }
            if(weeks > 0)
            {
                Console.WriteLine($"SEMANAS: {weeks}");
            }
            if (days > 0){
                Console.WriteLine($"DIAS: {days}");
            }
        }
    }
}

// OUTPUT
// Introduce un número de días: 391
// AÑOS: 1
// SEMANAS: 3
// DIAS: 5