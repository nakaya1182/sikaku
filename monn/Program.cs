using System;

namespace monn
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "十";
            Console.Write("\n");
            for (int hen = 25;hen>=0;hen-- )
            {
                int i = hen;
                for (; i >= 0; i--)
                {
                    Console.Write("　");
                }
                i = 26-hen;
                for (int j = 0; j < i; j++)
                {
                    Console.Write(str);
                    if(j!=i-1)
                        Console.Write(str);

                }
                Console.Write("\n");
            }
            for(int hen = 24; hen >= 0; hen--){
                Console.Write("　");
                for(int i = 24 - hen; i >= 0; i--)
                {
                    Console.Write("　");
                }

                for (int i = hen; i >= 0; i--)
                {
                    Console.Write(str);
                    if (i != hen )
                        Console.Write(str);
                }
                Console.Write("\n");

            }
        }
    }
}
