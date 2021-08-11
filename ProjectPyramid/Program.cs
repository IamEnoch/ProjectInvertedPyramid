using System;

namespace ProjectPyramid
{
    class Program
    {
        static void DrawPyramid(int n)//n defines how many rows you want your pyramid to have
        {
            for (int x = n; x >= 1; x--) 
            {
                for (int y = x; y <= n; y++) 
                {
                    Console.Write(" ");
                }
                for (int z = 1; z <= (2 * x - 1); z++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            DrawPyramid(5);
        }
    }
}
