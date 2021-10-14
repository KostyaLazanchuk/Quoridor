using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Menu
{
    class ResultPage: BasePages
    {

        public void VictoryOne()
        {
            Console.Clear();
            Console.WriteLine("Выграл первый игрок (нажмите любую кнопку)");
            Console.ReadKey();
            Console.WriteLine();
            SecondPages();

        }
        public void VictoryTwo()
        {
            Console.Clear();
            Console.WriteLine("Выграл Второй игрок (нажмите любую кнопку)");
            Console.ReadKey();
            Console.WriteLine();
            SecondPages();

        }
        public void Check(int name, int playerY)
        {
            if (name == 5)
            {
                if (playerY == 17)
                {
                    VictoryOne();
                }
            }
            if (name == 4)
            {
                if (playerY == 1)
                {
                    VictoryTwo();
                }
            }
        }
    }
}
