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
                            if (logicInfo.contsWallP1 == 0)
                            {
                                Console.WriteLine("У вас закончились стенки");
                                goto case "1";
                            }
                            else
                            {
                                logicInfo.PutWall(ref logicInfo.y, ref logicInfo.x, ref logicInfo.name1, ref map, ref logicInfo.contsW, ref logicInfo.x1, ref logicInfo.y1, ref logicInfo.name2, ref logicInfo.part, ref logicInfo.contsWallP1);
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
                            logicInfo.Step(ref logicInfo.costx1, ref logicInfo.y1, ref logicInfo.x1, ref logicInfo.name2, ref map, ref logicInfo.contsP, ref logicInfo.part);
                            Console.Clear();
                            break;
                        case "2":
                            if (logicInfo.contsWallP2 == 0)
                            {
                                Console.WriteLine("У вас закончились стенки");
                                goto case "1";
                            }
                            else
                            {
                                logicInfo.PutWall(ref logicInfo.y, ref logicInfo.x, ref logicInfo.name1, ref map, ref logicInfo.contsW, ref logicInfo.x1, ref logicInfo.y1, ref logicInfo.name2, ref logicInfo.part, ref logicInfo.contsWallP2);
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
