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
        public int wallx = 15, wally = 8, topleft = 1;
        public int wallmapx = 8, wallmapy = 8, eight = 0;
        private int contsWAL = 1;

        public void MoveW(ref int[,] map, int x, int y, int name1, int x1, int y1, int name2, ref int contsW)
        {
            DrawMap mapWork = new DrawMap();
            Console.SetCursorPosition(wallx, wally);
            ConsoleKeyInfo wall = Console.ReadKey(true);
            if (topleft == 0) Console.Write("-");
            else Console.Write("|");
            if (wall.Key == ConsoleKey.Tab && topleft == 1) topleft--;
            else if (wall.Key == ConsoleKey.Tab && topleft == 0) topleft++;
            if (wall.Key == ConsoleKey.LeftArrow && wallx - 4 >= 0 && map[wallmapy, wallmapx - 2] == 2)
            {
                if (wallmapx != 8 || wallmapy != 8 || eight == 0) map[wallmapy, wallmapx] = 2;
                wallx = wallx - 4;
                wallmapx = wallmapx - 2;
                if (topleft == 1)
                    map[wallmapy, wallmapx] = 7;
                else map[wallmapy, wallmapx] = 8;
            }
            if (wall.Key == ConsoleKey.RightArrow && wallx + 4 <= 34 && map[wallmapy, wallmapx + 2] == 2)
            {
                if (wallmapx != 8 || wallmapy != 8 || eight == 0) map[wallmapy, wallmapx] = 2;
                wallx = wallx + 4;
                wallmapx = wallmapx + 2;
                if (topleft == 1)
                    map[wallmapy, wallmapx] = 7;
                else map[wallmapy, wallmapx] = 8;
            }
            if (wall.Key == ConsoleKey.UpArrow && wally - 3 >= 0 && map[wallmapy - 2, wallmapx] == 2)
            {
                if (wallmapx != 8 || wallmapy != 8 || eight == 0) map[wallmapy, wallmapx] = 2;
                wally = wally - 2;
                wallmapy = wallmapy - 2;
                if (topleft == 1)
                    map[wallmapy, wallmapx] = 7;
                else map[wallmapy, wallmapx] = 8;
            }
            if (wall.Key == ConsoleKey.DownArrow && wally + 2 <= 17 && map[wallmapy + 2, wallmapx] == 2)
            {
                if (wallmapx != 8 || wallmapy != 8 || eight == 0) map[wallmapy, wallmapx] = 2;
                wally = wally + 2;
                wallmapy = wallmapy + 2;
                if (topleft == 1)
                    map[wallmapy, wallmapx] = 7;
                else map[wallmapy, wallmapx] = 8;
            }
            if (wall.Key == ConsoleKey.Enter)
            {
                wallx = 15;
                wally = 8;
                if (topleft == 1 && map[wallmapy + 1, wallmapx] != 7 && map[wallmapy - 1, wallmapx] != 7)
                {
                    map[wallmapy, wallmapx] = 7;
                    map[wallmapy - 1, wallmapx] = 7;
                    map[wallmapy + 1, wallmapx] = 7;
                    mapWork.FindW(map, x, y, ref contsWAL, name1);
                    contsWAL++;
                    mapWork.FindW(map, x1, y1, ref contsWAL, name2);
                    if (contsWAL > 0)
                    {
                        map[wallmapy, wallmapx] = 2;
                        map[wallmapy - 1, wallmapx] = 2;
                        map[wallmapy + 1, wallmapx] = 2;
                        contsWAL = 1;
                    }
                    else
                    {
                        if (wallmapy == 8 && wallmapx == 8) eight++;
                        contsWAL = 1;
                        contsW++;
                    }
                }
                else if (topleft == 0 && map[wallmapy, wallmapx - 1] != 8 && map[wallmapy, wallmapx + 1] != 8)
                {
                    map[wallmapy, wallmapx] = 8;
                    map[wallmapy, wallmapx - 1] = 8;
                    map[wallmapy, wallmapx + 1] = 8;
                    mapWork.FindW(map, x, y, ref contsWAL, name1);
                    contsWAL++;
                    mapWork.FindW(map, x1, y1, ref contsWAL, name2);
                    if (contsWAL > 0)
                    {
                        map[wallmapy, wallmapx] = 2;
                        map[wallmapy, wallmapx - 1] = 2;
                        map[wallmapy, wallmapx + 1] = 2;
                        contsWAL = 1;
                    }
                    else
                    {
                        if (wallmapy == 8 && wallmapx == 8) eight++;
                        contsWAL = 1;
                        contsW++;
                    }
                }
                else map[wallmapy, wallmapx] = 2;
                wallmapx = 8;
                wallmapy = 8;
            }
        }
    }
}
