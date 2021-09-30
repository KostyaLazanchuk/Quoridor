using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Menu
{
    class Pages
    {
        public void FirstEvent(string Choose)
        {
            switch (Choose)
            {
                case "start":
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("Не правильно ввели символ");
                    break;
            }
        }
        public void SecondEvent(string Choose)
        {
            Console.WriteLine("1: против ком");
            Console.WriteLine("2: против игрока");
            Console.WriteLine("3: назад");
            switch (Choose)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Не правильно ввели символ");
                    break;

            }
        }
    }
}
