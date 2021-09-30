using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Menu
{
    class Play : ResultPage
    {
        public void StartGamesVsAI()
        {
            //вызов метода с игрой
            Console.WriteLine("на стадии разработки");
            int a = Convert.ToInt32(Console.ReadLine());
            Victory(ref a);
        }
        public void StartGamesVsPlayer()
        {
            //вызов метода с игрой
            Console.WriteLine("на стадии разработки");
            int a = Convert.ToInt32(Console.ReadLine());
            Victory(ref a);
           
        }
    }
}
