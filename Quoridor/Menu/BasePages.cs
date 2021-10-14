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
            Console.WriteLine(" 1: начать игру \n 2: выйти из игры");
            choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    SecondPages();
                    break;
                case "2":
                    ExitEvent();
                    break;
                default:
                    Console.WriteLine(" Не правильно ввели символ");
                    break;
            }
        }
        public void SecondPages()
        {
            string choose;
            Console.WriteLine(" 1: против ком \n 2: против игрока \n 3: назад \n 4: помогите!");            
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
                case "4":
                    HelpPage();
                    break;
                default:
                    Console.WriteLine(" Не правильно ввели символ");
                    break;

            }
        }
        public void ExitEvent()
        {
            Console.WriteLine("Пока");
            return;
        }
        public void HelpPage()
        {
            Console.WriteLine(" Бог в помощь \n Нажмите любую кнопку, чтоб вернуться");
            Console.ReadKey();
            SecondPages();
        }
    }
}
