using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Triangle
    {
        internal void DrawATriangle(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size-(i+1); j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < (i*2)+1; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
