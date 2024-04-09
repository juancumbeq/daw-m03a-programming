using System;

namespace daw_m03a_programming
{
    class Switch_Case
    {
        static void Main(string[] args)
        {
            int number = 1;
            
            switch(number)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                
                default:
                    Console.WriteLine("Deafult Case");
                    break;
            }
        }
    }
}

// OUTPUT
// Case 1