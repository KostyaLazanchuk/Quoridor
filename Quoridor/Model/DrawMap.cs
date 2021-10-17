using System;
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
                    {1,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,1},
                    {1,0,2,0,2,0,2,0,2,5,2,0,2,0,2,0,2,0,1},
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
                    else if (array[i, j] == 3) Console.Write(" -");
                    else if (array[i, j] == 2) Console.Write("  ");
                    else if (array[i, j] == 4) Console.Write("? ");
                    else if (array[i, j] == 5) Console.Write("# ");
                    else Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void FindW(int[,] map, int FplayerX, int FplayerY, ref int contsWAL, int name)
        {
            int count1 = 10;
            bool finished = false;
            int height = 19;
            int lenght = 19;
            int[,] a = new int[19, 19];
            for (int i = 0; i < 19; i++)
                for (int j = 0; j < 19; j++)
                    a[i, j] = map[i, j];
            a[FplayerY, FplayerX] = count1;
            do
            {
                for (int i = 1; i < 19; i = i + 2)
                {
                    for (int j = 1; j < 19; j = j + 2)
                    {
                        if (a[i, j] == count1)
                        {
                            if (a[i + 1, j] == 2 && a[i + 2, j] != count1 - 1) a[i + 2, j] = count1 + 1;
                            if (a[i, j + 1] == 2 && a[i, j + 2] != count1 - 1) a[i, j + 2] = count1 + 1;
                            if (i != -1) if (a[i - 1, j] == 2 && a[i - 2, j] != count1 - 1) a[i - 2, j] = count1 + 1;
                            if (j != -1) if (a[i, j - 1] == 2 && a[i, j - 2] != count1 - 1) a[i, j - 2] = count1 + 1;
                            if (a[i + 1, j] == 9 && name == 5) finished = true;
                            if (a[i - 1, j] == 3 && name == 4) finished = true;
                        }
                    }
                }
                count1++;
            }
            while (!finished && count1 < height * lenght);
            if (count1 >= height * lenght)
            {
                contsWAL++;
            }
            else contsWAL--;
        }

    }
}
