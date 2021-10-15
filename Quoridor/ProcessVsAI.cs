using Quoridor.AI;
using Quoridor.Map;
using Quoridor.Menu;
using Quoridor.MoveChar;
using System;
using System.Threading;

public class ProcessVsAI
{
    public void Game()
    {
        int[,] map = new int[19, 19];
        DrawMap drawMap = new DrawMap();
        FindWay find = new FindWay();
        map = drawMap.Map();
        Move move = new Move();
        MoveWall movew = new MoveWall();
        int costx = 17, y = 1, x = 9, part = 0;
        int costx1 = 17, y1 = 17, x1 = 9;
        int name1 = 5;
        int name2 = 4;
        int contsW = 0;
        int contsP = 0;
        int contsWAL = 0;
        int contsWallP = 10;
        int contsWallAI = 10;
        ResultPage resultPage = new ResultPage();

        AIWall aiBot = new AIWall();
        AIMove aIMove = new AIMove();
        Random random = new Random();
        while (true)
        {
            drawMap.Paint(map);
            if (part == 0)
            {
                Console.WriteLine("Ходит Игрок");
                Console.WriteLine("Ходить или ставить стенку (1) или (2)?");
                Console.WriteLine("У вас осталось " + contsWallP + " стенок");
                string step = Console.ReadLine();
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
                        if (contsWallP == 0)
                        {
                            Console.WriteLine("У вас закончились стенки");
                            goto case "1";
                        }
                        while (true)
                        {
                            if (contsW == 0)
                            {
                                Console.Clear();
                                drawMap.Paint(map);
                                movew.MoveW(ref map, ref contsW, ref contsWAL);
                            }
                            else if (contsWAL == 1) find.FindW(map, x, y, x1, y1, ref contsWAL);
                            else
                            {
                                drawMap.Paint(map);
                                contsW--;
                                part++;
                                contsWallP--;
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
                Random morw = new Random();
                int rng = morw.Next(1, 3);
                while (true)
                {
                    if (rng == 1)
                    {
                        while (true)
                        {
                            if (contsP == 0)
                            {
                                int rnd = random.Next(1, 4);
                                drawMap.Paint(map);
                                aIMove.Move(ref costx1, ref y1, ref x1, ref name2, ref map, ref contsP, rnd);

                            }
                            else
                            {
                                resultPage.Check(name2, y1);
                                part--;
                                contsP--;
                                Console.Clear();
                                break;
                            }
                        }
                        break;

                    }
                    else if (contsWallAI != 0 && rng == 2)
                    {
                        while (true)
                        {
                            if (contsW == 0)
                            {
                                Console.Clear();
                                drawMap.Paint(map);
                                aiBot.MoveWall(ref map, ref contsW, ref contsWAL);
                            }
                            else if (contsWAL == 1) find.FindW(map, x, y, x1, y1, ref contsWAL);
                            else
                            {
                                drawMap.Paint(map);
                                contsW--;
                                part--;
                                contsWallAI--;
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
