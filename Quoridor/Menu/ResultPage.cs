using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Menu
{
    class ResultPage
    {
        public void Victory(ref int a)
        {
            Console.Clear();
            if (a==1)
            {
                Console.WriteLine("Выграл первый игрок");
            }
            else
            {
                Console.WriteLine("Выграл второй игрок");
            }
            
        }       
    }
}
