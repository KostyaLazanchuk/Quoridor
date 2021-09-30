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
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
