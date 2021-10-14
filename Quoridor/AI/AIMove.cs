using System;

namespace Quoridor.AI
{
    class AIMove
    {
    public void Move(ref int costx, ref int playerY, ref int playerX, ref int name, ref int[,] map, int number)
{
    Console.SetCursorPosition(costx, playerY);
    if (number == 1)
    {
        map[playerY, playerX] = 0;
        playerX = playerX - 2;
        costx = costx - 4;
        map[playerY, playerX] = name;
    }
    else if (number == 2)
    {
        map[playerY, playerX] = 0;
        playerX = playerX + 2; costx = costx + 4;
        map[playerY, playerX] = name;
    }
    else if (number == 3)
    {
        map[playerY, playerX] = 0;
        playerY = playerY - 2;
        map[playerY, playerX] = name;
    }
    else if (number == 4)
    {
        map[playerY, playerX] = 0;
        playerY = playerY + 2;
        map[playerY, playerX] = name;
    }

   }
}

