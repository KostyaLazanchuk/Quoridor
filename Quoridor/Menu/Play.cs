using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Menu
{
    class Play
    {
        ProcessVsPlayers process = new ProcessVsPlayers();
        ProcessVsAI process1 = new ProcessVsAI();
        public void StartGamesVsAI()
        {
            Console.Clear();
            process1.Game();

        }
        public void StartGamesVsPlayer()
        {
            Console.Clear();
            process.Game();
      
        }
    }
}
