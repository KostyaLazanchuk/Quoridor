using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.AI
{
    class AI
    {
        public void Choose()
        {
            Random random = new Random();
            int number = random.Next(1, 2);
            if (number == 1)
            {
                //Ходить
                int move = random.Next(1, 4);
                switch (move)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
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
