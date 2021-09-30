using Quoridor.Map;
using Quoridor.MoveChar;
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
            Move move = new Move();
            int costx = 17, y = 1, x = 9, part = 0; 
            int costx1 = 17, y1 = 17, x1 = 9; 
            int name1 = 5;
            int name2 = 4;
            while (true)
            {
                if (part == 0)
                {
                    
                    move.MoveP(ref costx, ref y, ref x, ref name1, ref map);
                    part++;
                    Console.Clear();
                    drawMap.Paint();
                }
                else if (part == 1)
                {
                    
                    move.MoveP(ref costx1, ref y1, ref x1, ref name2, ref map);
                    part--;
                    Console.Clear();
                    drawMap.Paint();

                }
            }
          
            /*while (true)
            {
                Console.SetCursorPosition(costx, y);
                Console.Write("#");
                ConsoleKeyInfo ki = Console.ReadKey(true);
                if (ki.Key == ConsoleKey.LeftArrow && costx - 4 >= 0 && map[y,x-1] == 2) { x = x - 2; costx = costx - 4; }
                if (ki.Key == ConsoleKey.RightArrow && costx + 4 <= 34 && map[y, x+1] == 2) { x = x + 2; costx = costx + 4; }
                if (ki.Key == ConsoleKey.UpArrow && y-2 >= 0 && map[y - 1, x] == 2) y=y-2;
                if (ki.Key == ConsoleKey.DownArrow && y+2 <= 17 && map[y + 1, x] == 2) y=y+2;
            }*/
        }
    }
}