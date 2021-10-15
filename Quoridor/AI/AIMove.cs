using System;

namespace Quoridor.AI
{
    class AIMove
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
    }
}

