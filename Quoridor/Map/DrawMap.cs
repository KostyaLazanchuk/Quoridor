﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Map
{
    class DrawMap
    {
        public int[,] Map()
        {
            int[,] array = new int[19, 19]
            {
                    {1,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,1},
                    {1,0,7,0,2,0,2,0,2,5,7,0,2,0,2,0,2,0,1},
                    {1,2,7,2,2,2,2,8,8,8,7,2,2,2,2,2,2,2,1},
                    {1,0,7,0,2,0,2,0,2,0,7,0,2,0,2,0,2,0,1},
                    {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
                    {1,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,1},
                    {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
                    {1,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,1},
                    {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
                    {1,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,1},
                    {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
                    {1,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,1},
                    {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
                    {1,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,1},
                    {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
                    {1,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,1},
                    {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
                    {1,0,2,0,2,0,2,0,2,4,2,0,2,0,2,0,2,0,1},
                    {1,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,1}
            };

            return array;
        }
        public void Paint(int[,] array)
        {

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (array[i, j] == 1) Console.Write("|");
                    else if (array[i, j] == 7) Console.Write("| ");
                    else if (array[i, j] == 8) Console.Write("--");
                    else if (array[i, j] == 9) Console.Write(" -");
                    else if (array[i, j] == 2) Console.Write("  ");
                    else if (array[i, j] == 4) Console.Write("? ");
                    else if (array[i, j] == 5) Console.Write("# ");
                    else Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
