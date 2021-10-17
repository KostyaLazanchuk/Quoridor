using Quoridor.Map;
using Quoridor.Menu;
using Quoridor.MoveChar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Quoridor
{
    class ProcessVsPlayers
    {
        public void Game()
        {
            int[,] map = new int[19, 19];
            DrawMap mapWork = new DrawMap();
            map = mapWork.Map();

            Move move = new Move();
            ResultPage resultPage = new ResultPage();

            LogicInfo logicInfo = new LogicInfo();

            while (true)
            {
                mapWork.Paint(map);
                Console.WriteLine($"Ходит игрок {logicInfo.part + 1}");
                Console.WriteLine("Ходить или ставить стенку (1) или (2)?");
                Console.WriteLine("Стенок у игрока 1: " + logicInfo.contsWallP1);
                Console.WriteLine("Стенок у игрока 2: " + logicInfo.contsWallP2);
                string step = Console.ReadLine();
                if (logicInfo.part == 0)
                {

                    switch (step)
                    {
                        case "1":
                            logicInfo.Step(ref logicInfo.costx, ref logicInfo.y, ref logicInfo.x, ref logicInfo.name1, ref map, ref logicInfo.contsP, ref logicInfo.part);
                            Console.Clear();
                            break;
                        case "2":
                            if (logicInfo.contsWallP1 == 0) goto case "1";
                            while (true)
                            {
                                if (logicInfo.contsW == 0)
                                {
                                    Console.Clear();
                                    mapWork.Paint(map);
                                    move.MoveW(ref map, logicInfo.x, logicInfo.y, logicInfo.name1, logicInfo.x1, logicInfo.y1, logicInfo.name2, ref logicInfo.contsW);
                                }
                                else
                                {
                                    mapWork.Paint(map);
                                    logicInfo.contsW--;
                                    logicInfo.part++;
                                    logicInfo.contsWallP1--;
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
                else if (logicInfo.part == 1)
                {

                    switch (step)
                    {
                        case "1":

                            /* while (true)
                             {
                                 if (logicInfo.contsP == 0)
                                 {
                                     Console.Clear();
                                     mapWork.Paint(map);
                                     move.MoveP(ref logicInfo.costx1, ref logicInfo.y1, ref logicInfo.x1, ref logicInfo.name2, ref map, ref logicInfo.contsP);
                                 }
                                 else
                                 {
                                     resultPage.Check(logicInfo.name2, logicInfo.y1);
                                     logicInfo.part--;
                                     logicInfo.contsP--;
                                     break;
                                 }
                             }*/
                            logicInfo.Step(ref logicInfo.costx1, ref logicInfo.y1, ref logicInfo.x1, ref logicInfo.name2, ref map, ref logicInfo.contsP, ref logicInfo.part);
                            Console.Clear();
                            break;
                        case "2":
                            if (logicInfo.contsWallP2 == 0) goto case "1";
                            while (true)
                            {
                                if (logicInfo.contsW == 0)
                                {
                                    Console.Clear();
                                    mapWork.Paint(map);
                                    move.MoveW(ref map, logicInfo.x, logicInfo.y, logicInfo.name1, logicInfo.x1, logicInfo.y1, logicInfo.name2, ref logicInfo.contsW);
                                }
                                else
                                {
                                    mapWork.Paint(map);
                                    logicInfo.contsW--;
                                    logicInfo.part--;
                                    logicInfo.contsWallP2--;
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
