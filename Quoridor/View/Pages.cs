using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Menu
{
    class Pages
    {
        ProcessVsPlayers process = new ProcessVsPlayers();
        ProcessVsAI process1 = new ProcessVsAI();
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
            Console.WriteLine(" Ходьба: стрелочки \n Чтобы поставить стенку, нажмите Enter \n Чтобы переверунть стенку, нажмите Tab \n Нажмите любую кнопку, чтоб вернуться");
            Console.WriteLine(" Коридор (Quoridor) – по сути своей является чем-то средним между гонками и лабиринтом. \n Правила предельно просты. Нужно провести фишку от одного края поля к другому быстрее чем это сделает соперник. \n Дополнительной остроты событиям прибавляет возможность каждого из игроков устанавливать преграды в любой части поля. \n Таким образом можно облегчить себе путь или нарушить планы оппонента. \n Фишка игрока перегородки перепрыгивать не умеет, их придется обходить, поэтому можно очень сильно \n озадачить своего партнера по игре неожиданной перепонкой. \n Но не забывайте, что число их ограничено, а пополнения запасов не предвидится. \n Если вы используете все доступные преграды, продолжать придется без них. \n Кстати, в ход можно делать только одно действие: либо передвинуть свою фишку на одну клетку в \n любом из направлений, кроме как по диагонали, либо же поставить перегородку. \n И самое главное, нельзя полностью перекрывать сопернику путь к финишу, лазейка всегда должна оставаться. ");
            Console.ReadKey();
            SecondPages();
        }
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
