using System;

public class Process1
{
    public void Game()
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
        AiBot aiBot = new AiBot();
        AIMove aIMove = new AIMove();
        Random random = new Random();


    }
            while (true)
            {
                drawMap.Paint(map);
                if (part == 0)
                {
                    Console.WriteLine("Ходить или ставить стенку (1) или (2)?");
                    string step = Console.ReadLine();
                    switch (step)
                    {
                        case "1":
                            Thread.Sleep(500);
                            move.MoveP(ref costx, ref y, ref x, ref name1, ref map);
                            part++;
                            Console.Clear();
                            break;
                        case "2":
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
                int kek = random.Next(1, 4);
                Thread.Sleep(500);
                drawMap.Paint(map);
                aIMove.Move(ref costx1, ref y1, ref x1, ref name2, ref map, kek);
                part--;
                Console.Clear();

                }
            }
}
