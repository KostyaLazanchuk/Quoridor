using Quoridor.Map;
using Quoridor.MoveChar;
using System;
using System.Threading;

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
            MoveWall movew = new MoveWall();
            int costx = 17, y = 1, x = 9, part = 0;
            int costx1 = 17, y1 = 17, x1 = 9;
            int name1 = 5;
            int name2 = 4;
            int conts = 0;
            while (true)
            {
                if (conts == 0)
                {
                    Console.Clear();
                    drawMap.Paint(map);
                    movew.MoveW(ref map, ref conts);
                }
                else
                {
                    drawMap.Paint(map);
                    conts--;
                }
            }
            /*while (true)
            {
                drawMap.Paint(map);
                Console.WriteLine($"Ходит игрок {part + 1}");
                Console.WriteLine("Ходить или ставить стенку (1) или (2)?");            
                string step = Console.ReadLine();
                if (part == 0)
                {

                    switch (step)
                    {
                        case "1":
                            Thread.Sleep(500);
                            move.MoveP(ref costx, ref y, ref x, ref name1, ref map);
                            part++;
                            Console.Clear();
                            break;
                        case "2":
                            Console.Clear();
                            break;
                        default:                          
                            Console.WriteLine("Не прввильно сделан ход (намжмите любую кнопку, чтобы продолжить)");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                       
                    }
                }
                else if (part == 1)
                {

                    switch (step)
                    {
                        case "1":
                            Thread.Sleep(500);
                            move.MoveP(ref costx1, ref y1, ref x1, ref name2, ref map);
                            part--;
                            Console.Clear();
                            break;
                        case "2":
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Не прввильно сделан ход (намжмите любую кнопку, чтобы продолжить)");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        

                    }
                }
            }
            */
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