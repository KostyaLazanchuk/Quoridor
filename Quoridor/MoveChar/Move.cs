using Quoridor.Map;
using Quoridor.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Quoridor.MoveChar
{
    class Move 
    {
 

        public void MoveP(ref int costx, ref int playerY, ref int playerX, ref int name,ref int[,] map, ref int contsP)
        {

            Console.SetCursorPosition(costx, playerY);

            ConsoleKeyInfo player1 = Console.ReadKey(true);

            if (player1.Key == ConsoleKey.LeftArrow && costx - 4 >= 0 && map[playerY, playerX - 1] == 2)
            {
                map[playerY, playerX] = 0;
                playerX = playerX - 2;
                costx = costx - 4;
                map[playerY, playerX] = name;
                contsP++;

            }
            if (player1.Key == ConsoleKey.RightArrow && costx + 4 <= 34 && map[playerY, playerX + 1] == 2)
            {
                map[playerY, playerX] = 0;
                playerX = playerX + 2; costx = costx + 4;
                map[playerY, playerX] = name;
                contsP++;
            }
            if (player1.Key == ConsoleKey.UpArrow && playerY - 2 >= 0 && map[playerY - 1, playerX] == 2)
            {
                map[playerY, playerX] = 0;
                playerY = playerY - 2;
                map[playerY, playerX] = name;
                contsP++;
            }

            if (player1.Key == ConsoleKey.DownArrow && playerY + 2 <= 17 && map[playerY + 1, playerX] == 2)
            {
                map[playerY, playerX] = 0;
                playerY = playerY + 2;
                map[playerY, playerX] = name;
                contsP++;
            }

            


        }
    }
}
