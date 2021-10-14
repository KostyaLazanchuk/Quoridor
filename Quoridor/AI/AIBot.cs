using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.AI
{
    class AiBot
    {
        public void Choose(ref int[,] map)
        {
            Random random = new Random();
            int costx1 = 17, y1 = 17, x1 = 9;
            int name2 = 4;
            AIMove aIMove = new AIMove();
            int number = random.Next(1, 1);
            int move = random.Next(1, 4);

            aIMove.Move(ref costx1, ref y1, ref x1, ref name2, ref map, move);
            /if (number == 1)
            {
                //Ходить

            }
            else
            {
                //Ставить стенки
                int position = random.Next(1, 2);
                switch (position)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                }


            }
        }
    }
}
