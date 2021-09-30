using System;
using System.Collections.Generic;
using System.Text;

namespace Quoridor.Map
{
    class Array
    {
        public int[,] Map()
        {
            Random random = new Random();
            int[,] array = new int[18, 18]; 
            for (int i=0; i<18 ; i++)
            {
                for (int j=0; j<18;j++)
                {
                    array[i,j] = random.Next(1,5);
                }
                
            }
            return array;
        }
    }
}
