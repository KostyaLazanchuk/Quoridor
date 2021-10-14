using Quoridor.Map;
using Quoridor.Menu;
using Quoridor.MoveChar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Quoridor
{
    class Process
    {
        public void Game()
        {
            int[,] map = new int[19, 19];
            DrawMap drawMap = new DrawMap();
            map = drawMap.Map();
            Move move = new Move();
            MoveWall movew = new MoveWall();
            ResultPage resultPage = new ResultPage();
            int costx = 17, y = 1, x = 9, part = 0;
            int costx1 = 17, y1 = 17, x1 = 9;
            int name1 = 5;
            int name2 = 4;
            int contsW = 0;
            int contsP = 0;

            while (true)
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
                            while (true)
                            {
                                if (contsP == 0)
                                {
                                    Console.Clear();
                                    drawMap.Paint(map);
                                    move.MoveP(ref costx, ref y, ref x, ref name1, ref map, ref contsP);
                                }
                                else
                                {
                                    resultPage.Check(name1, y);
                                    part++;
                                    contsP--;
                                    break;
                                }
                            }
                            Console.Clear();
                            break;
                        case "2":
                            while (true)
                            {
                                if (contsW == 0)
                                {
                                    Console.Clear();
                                    drawMap.Paint(map);
                                    movew.MoveW(ref map, ref contsW);
                                }
                                else
                                {
                                    drawMap.Paint(map);
                                    contsW--;
                                    part++;
                                    break;
                                }

                            }
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Не правильно сделан ход (намжмите любую кнопку, чтобы продолжить)");
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
                            while (true)
                            {
                                if(contsP == 0)
                                {
                                    Console.Clear();
                                    drawMap.Paint(map);
                                    move.MoveP(ref costx1, ref y1, ref x1, ref name2, ref map, ref contsP);
                                }
                                else 
                                {
                                    resultPage.Check(name2, y1);
                                    part--;
                                    contsP--;
                                    break; 
                                }
                            }
                            Console.Clear();
                            break;
                        case "2":
                            while (true)
                            {
                                if (contsW == 0)
                                {
                                    Console.Clear();
                                    drawMap.Paint(map);
                                    movew.MoveW(ref map, ref contsW);
                                }
                                else
                                {
                                    drawMap.Paint(map);
                                    contsW--;
                                    part--;
                                    break;
                                }

                            }
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Не правильно сделан ход (намжмите любую кнопку, чтобы продолжить)");
                            Console.ReadKey();
                            Console.Clear();
                            break;


                    }
                }
            }
        }
    }
}
