using Quoridor.Map;
using Quoridor.Menu;
using Quoridor.MoveChar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor
{
    class LogicInfo
    {
        public int costx = 17, y = 1, x = 9, part = 0;
        public int costx1 = 17, y1 = 17, x1 = 9;
        public int name1 = 5;
        public int name2 = 4;
        public int contsW = 0;
        public int contsP = 0;
        public int contsWallP = 10;
        public int contsWallAI = 10;
        public int contsWallP1 = 10;
        public int contsWallP2 = 10;
        public LogicInfo()
        {

        }
        public void Step(ref int costx, ref int y, ref int x, ref int name1, ref int[,] map, ref int contsP, ref int part)
        {
            Move move = new Move();
            Pages pages = new Pages();


            DrawMap mapWork = new DrawMap();

            while (true)
            {
                if (contsP == 0)
                {
                    Console.Clear();
                    mapWork.Paint(map);
                    move.MoveP(ref costx, ref y, ref x, ref name1, ref map, ref contsP);
                }
                else
                {
                    pages.Check(name1, y);
                    if (part == 1)
                    {
                        part--;
                    }
                    else
                    {
                        part++;

                    }
                    contsP--;
                    break;
                }
            }
        }
        public void PutWall(ref int y, ref int x, ref int name1, ref int[,] map, ref int contsW, ref int x1, ref int y1, ref int name2, ref int part, ref int contsWallP1)
        {
            Move move = new Move();
            DrawMap mapWork = new DrawMap();

            while (true)
            {
                if (contsW == 0)
                {
                    Console.Clear();
                    mapWork.Paint(map);
                    move.MoveW(ref map, x, y, name1, x1, y1, name2, ref contsW);
                }
                else
                {
                    mapWork.Paint(map);
                    contsW--;
                    if(part==0)
                    {
                        part++;
                    }
                    else
                    {
                        part--;
                    }
                    
                    contsWallP1--;
                    break;
                }

            }
        }


    }
}
