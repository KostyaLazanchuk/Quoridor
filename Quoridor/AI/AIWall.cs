using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.AI
{
    class AIWall
    {
        public void MoveWall(ref int[,] map, ref int contsW)
        {
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
                        break;
                    }
                }
                else
                {
                    if (map[wally, wallx] == 2 && map[wally, wallx - 1] == 2 && map[wally, wallx + 1] == 2)
                    {
                        map[wally, wallx] = 8;
                        map[wally, wallx + 1] = 8;
                        map[wally, wallx - 1] = 8;
                        break;
                    }
                }
            }
            contsW++;
        }
    }
}
