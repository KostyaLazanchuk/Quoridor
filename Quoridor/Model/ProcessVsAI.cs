using Quoridor;
using Quoridor.AI;
using Quoridor.Map;
using Quoridor.Menu;
using System;

public class ProcessVsAI
{
    public void Game()
    {
        int[,] map = new int[19, 19];
        DrawMap mapWork = new DrawMap();
        map = mapWork.Map();
      
        LogicInfo logicInfo = new LogicInfo();
        Pages pages = new Pages();

        AiBot aIMove = new AiBot();
        Random random = new Random();
        while (true)
        {
            mapWork.Paint(map);
            if (logicInfo.part == 0)
            {
                Console.WriteLine("Ходит Игрок");
                Console.WriteLine("Ходить или ставить стенку (1) или (2)? \nВыйти из игры (3) ");
                Console.WriteLine("У вас осталось " + logicInfo.contsWallP + " стенок");
                string step = Console.ReadLine();
                switch (step)
                {
                    case "1":
                        logicInfo.Step(ref logicInfo.costx, ref logicInfo.y, ref logicInfo.x, ref logicInfo.name1, ref map, ref logicInfo.contsP, ref logicInfo.part);
                        Console.Clear();
                        break;
                    case "2":
                        if (logicInfo.contsWallP == 0)
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
                    case "3":
                        {
                            pages.FirstPages();
                            break;
                        }
                    default:
                        Console.WriteLine("Не правильно сделан ход (намжмите любую кнопку, чтобы продолжить)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            else if (logicInfo.part == 1)
            {
                Random morw = new Random();
                int rng = morw.Next(1, 3);
                while (true)
                {
                    if (rng == 1)
                    {
                        while (true)
                        {
                            if (logicInfo.contsP == 0)
                            {
                                int rnd = random.Next(1, 4);
                                mapWork.Paint(map);
                                aIMove.Move(ref logicInfo.costx1, ref logicInfo.y1, ref logicInfo.x1, ref logicInfo.name2, ref map, ref logicInfo.contsP, rnd);

                            }
                            else
                            {
                                pages.Check(logicInfo.name2, logicInfo.y1);
                                logicInfo.part--;
                                logicInfo.contsP--;
                                Console.Clear();
                                break;
                            }
                        }
                        break;

                    }
                    else if (logicInfo.contsWallAI != 0 && rng == 2)
                    {
                        while (true)
                        {
                            if (logicInfo.contsW == 0)
                            {
                                Console.Clear();
                                mapWork.Paint(map);
                                aIMove.MoveWall(ref map, logicInfo.x, logicInfo.y, logicInfo.name1, logicInfo.x1, logicInfo.y1, logicInfo.name2, ref logicInfo.contsW);
                            }
                            else
                            {
                                mapWork.Paint(map);
                                logicInfo.contsW--;
                                logicInfo.part--;
                                logicInfo.contsWallAI--;
                                break;
                            }
                        }
                        Console.Clear();
                        break;
                    }
                    else rng = 1;
                }
            }
        }

    }
}
