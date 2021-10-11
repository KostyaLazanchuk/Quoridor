using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Menu
{
    class Play : ResultPage
    {
        Process process = new Process();
        public void StartGamesVsAI()
        {
            //вызов метода с игрой
            Console.WriteLine("на стадии разработки");
            int a = Convert.ToInt32(Console.ReadLine());
            Victory(ref a);
        }
        public void StartGamesVsPlayer()
        {
            Console.Clear();
            process.Game();
            int a = Convert.ToInt32(Console.ReadLine());
            Victory(ref a);

        }
    }
}
