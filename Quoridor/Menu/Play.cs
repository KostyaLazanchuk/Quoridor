using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Menu
{
    class Play
    {
        Process process = new Process();
        Process1 process1 = new Process1();
        public void StartGamesVsAI()
        {
            //вызов метода с игрой
            process1.Game();

        }
        public void StartGamesVsPlayer()
        {
            Console.Clear();
            process.Game();
      
        }
    }
}
