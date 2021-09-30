using Quoridor.Map;
using System;

namespace Quoridor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] map = new int[19, 19];
            DrawMap drawMap = new DrawMap();
            map = drawMap.Map();
            int costx = 17, y = 1,x = 9;
            while (true)
            {
                Console.CursorLeft = costx;
                Console.CursorTop = y;
                Console.Write("#");
                ConsoleKeyInfo ki = Console.ReadKey(true);
                if (ki.Key == ConsoleKey.LeftArrow && costx - 4 >= 0 && map[y,x-1] == 2) { x = x - 2; costx = costx - 4; }
                if (ki.Key == ConsoleKey.RightArrow && costx + 4 <= 34 && map[y, x+1] == 2) { x = x + 2; costx = costx + 4; }
                if (ki.Key == ConsoleKey.UpArrow && y-2 >= 0 && map[y - 1, x] == 2) y=y-2;
                if (ki.Key == ConsoleKey.DownArrow && y+2 <= 17 && map[y + 1, x] == 2) y=y+2;
            }
        }
    }
}