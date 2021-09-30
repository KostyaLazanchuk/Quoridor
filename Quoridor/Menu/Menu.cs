using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Menu
{
    class Menu
    {
        private string choose;
        public string Choose
        {
            get
            {
                if (choose != " ")
                {
                    return choose;
                }
                else
                {
                    return "Ничего не выбрали";
                }

            }
            set
            {
                choose = value;
            }
        }
    }
}
