using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.MoveChar
{
    class MoveWall
    {
        public int wallx = 15, wally = 8, topleft = 0;
        public int wallmapx = 8, wallmapy = 8;
        public void MoveW(ref int[,] map, ref int conts)
        {
            Console.SetCursorPosition(wallx, wally);
            ConsoleKeyInfo wall = Console.ReadKey(true);
            if (topleft == 1) Console.Write("-");
            else Console.Write("|");
            if (wall.Key == ConsoleKey.Tab && topleft == 1) topleft--;
            if (wall.Key == ConsoleKey.Tab && topleft == 0) topleft++;
            if (wall.Key == ConsoleKey.LeftArrow && wallx - 4 >= 0)
            {
                map[wallmapy, wallmapx] = 2;
                wallx = wallx - 4;
                wallmapx = wallmapx - 2;
                if (topleft == 1)
                    map[wallmapy, wallmapx] = 7;
                else map[wallmapy, wallmapx] = 8;
            }
            if (wall.Key == ConsoleKey.RightArrow && wallx + 4 <= 34)
            {
                map[wallmapy, wallmapx] = 2;
                wallx = wallx + 4;
                wallmapx = wallmapx + 2;
                if (topleft == 1)
                    map[wallmapy, wallmapx] = 7;
                else map[wallmapy, wallmapx] = 8;
            }
            if (wall.Key == ConsoleKey.UpArrow && wally - 2 >= 0)
            {
                map[wallmapy, wallmapx] = 2;
                wally = wally - 2;
                wallmapy = wallmapy - 2;
                if (topleft == 1)
                    map[wallmapy, wallmapx] = 7;
                else map[wallmapy, wallmapx] = 8;
            }
            if (wall.Key == ConsoleKey.DownArrow && wally + 2 <= 17)
            {
                map[wallmapy, wallmapx] = 2;
                wally = wally + 2;
                wallmapy = wallmapy + 2;
                if (topleft == 1)
                    map[wallmapy, wallmapx] = 7;
                else map[wallmapy, wallmapx] = 8;
            }
            if (wall.Key == ConsoleKey.Enter)
            {
                if (topleft == 1)
                {
                    map[wallmapy, wallmapx] = 7;
                    map[wallmapy - 1, wallmapx] = 7;
                    map[wallmapy + 1, wallmapx] = 7;
                    conts++;
                }
                else
                {
                    map[wallmapy, wallmapx] = 8;
                    map[wallmapy, wallmapx - 1] = 8;
                    map[wallmapy, wallmapx + 1] = 8;
                    conts++;
                }
            }
        }
    }
}
