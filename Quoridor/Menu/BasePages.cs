using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Menu
{
    class BasePages: Play
    {
        public void FirstPages()
        {
            string choose;
            Console.WriteLine(" start: начать игру \n exit: выйти из игры");
            choose = Console.ReadLine();
            switch (choose)
            {
                case "start":
                    SecondPages();
                    break;
                case "exit":
                    ExitEvent();
                    break;
                default:
                    Console.WriteLine("Не правильно ввели символ");
                    break;
            }
        }
        public void SecondPages()
        {
            string choose;
            Console.WriteLine(" 1: против ком \n 2: против игрока \n 3: назад");
            choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    StartGamesVsAI();
                    SecondPages();
                    break;
                case "2":
                    StartGamesVsPlayer();
                    SecondPages();
                    break;
                case "3":
                    FirstPages();
                    break;
                default:
                    Console.WriteLine("Не правильно ввели символ");
                    break;

            }
        }
        public void ExitEvent()
        {
            Console.WriteLine("Пока");
            return;
        }
    }
}
