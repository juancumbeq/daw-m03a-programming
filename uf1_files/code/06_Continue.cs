using System;

namespace daw_m03a_programming
{
    class Continue
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 10; i++)
            {
                if (i < 9)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}

//OUTPUT
// 9
// 10