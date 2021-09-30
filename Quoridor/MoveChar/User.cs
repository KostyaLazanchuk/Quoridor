using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.MoveChar
{
    class User
    {
        private string name;
        private int[,] position;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int[,] Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }


    }
}
