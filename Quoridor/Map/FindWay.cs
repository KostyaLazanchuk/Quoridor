using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Map
{
    class FindWay
    {
        public void FindW(int[,] map, int FplayerX, int FplayerY,ref int constWAL, int name)
        {
            int count1 = 10;
            bool finished = false;
            int height = 19;
            int lenght = 19;
            int[,] a = new int[19,19];
            for (int i = 0; i < 19; i++)
                for (int j = 0; j < 19; j++)
                    a[i, j] = map[i, j];
            a[FplayerY, FplayerX] = count1;
            do
            {
                for (int i = 1; i < height; i = i + 2)
                {
                    for (int j = 1; j < lenght; j = j + 2)
                    {
                        if (a[i, j] == count1)
                        {
                            if (i != count1 - 1) if (a[i + 1, j] == 2 && a[i+2, j]!=count1-1) a[i + 2, j] = count1 + 1;
                            if (j != count1 - 1) if (a[i, j + 1] == 2 && a[i,j+2]!=count1-1) a[i, j + 2] = count1 + 1;
                            if (i != 0) if (a[i - 1, j] == 2 && a[i-2,j]!=count1-1) a[i - 2, j] = count1 + 1;
                            if (j != 0) if (a[i, j - 1] == 2 && a[i,j-2]!=count1-1) a[i, j - 2] = count1 + 1;
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
                Console.Clear();
                Console.ReadKey();
            }
            constWAL--;
        }
    }
}
