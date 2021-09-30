using Quoridor.Map;
using System;

namespace Quoridor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] map = new int[17, 17];
            DrawMap drawMap = new DrawMap();
            map = drawMap.Map();
           
        }
    }
}
