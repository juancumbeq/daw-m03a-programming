using System;

namespace daw_m03a_programming
{
    class Break
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if (i == 5)
                {
                    break;
                }
            Console.WriteLine(i);
            }
        }
    }
}

// OUTPUT
// 1
// 2
// 3
// 4