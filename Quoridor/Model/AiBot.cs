using Quoridor.Map;
using System;

namespace Quoridor.AI
{
    class AiBot
    {
        public void Move(ref int costx, ref int playerY, ref int playerX, ref int name, ref int[,] map, ref int contsP , int number)
        {
            Console.SetCursorPosition(costx, playerY);
            if (number == 1 && costx - 4 >= 0 && map[playerY, playerX - 1] == 2)
            {
                map[playerY, playerX] = 0;
                playerX = playerX - 2;
                costx = costx - 4;
                map[playerY, playerX] = name;
                contsP++;
            }
            else if (number == 2 && costx + 4 <= 34 && map[playerY, playerX + 1] == 2)
            {
                map[playerY, playerX] = 0;
                playerX = playerX + 2; costx = costx + 4;
                map[playerY, playerX] = name;
                contsP++;
            }
            else if (number == 3 && playerY - 2 >= 0 && map[playerY - 1, playerX] == 2)
            {
                map[playerY, playerX] = 0;
                playerY = playerY - 2;
                map[playerY, playerX] = name;
                contsP++;
            }
            else if (number == 4 && playerY + 2 <= 17 && map[playerY + 1, playerX] == 2)
            {
                map[playerY, playerX] = 0;
                playerY = playerY + 2;
                map[playerY, playerX] = name;
                contsP++;
            }

        }
        public void MoveWall(ref int[,] map, int x, int y, int name1, int x1, int y1, int name2, ref int contsW)
        {
            int contsWAL = 0;
            DrawMap mapWork = new DrawMap();
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
                    if (map[wally, wallx] == 2 && map[wally - 1, wallx] == 2 && map[wally + 1, wallx] == 2)
                    {
                        map[wally, wallx] = 7;
                        map[wally - 1, wallx] = 7;
                        map[wally + 1, wallx] = 7;
                        mapWork.FindW(map, x, y, ref contsWAL, name1);
                        contsWAL++;
                        mapWork.FindW(map, x1, y1, ref contsWAL, name2);
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
                        mapWork.FindW(map, x, y, ref contsWAL, name1);
                        contsWAL++;
                        mapWork.FindW(map, x1, y1, ref contsWAL, name2);
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

