using Quoridor.Map;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.AI
{
    class AIWall
    {

        public void MoveWall(ref int[,] map, int x, int y, int name1, int x1, int y1, int name2,ref int contsW)
        {
            int contsWAL = 0;
            FindWay find = new FindWay();
            while (true)
            {
                Random rng = new Random();
                float topleft = rng.Next(1, 3);
                int wallx = rng.Next(2, 17);
                if (wallx % 2 == 1) wallx++;
                int wally = rng.Next(2, 17);
                if (wally % 2 == 1) wally++;
                if (topleft == 1)
                {
                    if (map[wally, wallx] == 2 && map[wally-1, wallx] == 2 && map[wally+1,wallx] == 2)
                    {
                        map[wally, wallx] = 7;
                        map[wally - 1, wallx] = 7;
                        map[wally + 1, wallx] = 7;
                        find.FindW(map, x, y, ref contsWAL, name1);
                        contsWAL++;
                        find.FindW(map, x1, y1, ref contsWAL, name2);
                        if (contsWAL > 0)
                        {
                            map[wally, wallx] = 2;
                            map[wally - 1, wallx] = 2;
                            map[wally + 1, wallx] = 2;
                        }
                        else break;
                    }
                }
                else
                {
                    if (map[wally, wallx] == 2 && map[wally, wallx - 1] == 2 && map[wally, wallx + 1] == 2)
                    {
                        map[wally, wallx] = 8;
                        map[wally, wallx + 1] = 8;
                        map[wally, wallx - 1] = 8; 
                        find.FindW(map, x, y, ref contsWAL, name1);
                        contsWAL++;
                        find.FindW(map, x1, y1, ref contsWAL, name2);
                        if (contsWAL > 0)
                        {
                            map[wally, wallx] = 2;
                            map[wally, wallx + 1] = 2;
                            map[wally, wallx - 1] = 2;
                        }
                        else break;
                    }
                }
            }
            contsW++;
        }
    }
}
