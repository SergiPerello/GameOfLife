using System;
using System.Collections.Generic;
using System.Text;

namespace GameLife
{
    class Game
    {
        Cell[,] array;

        public Game(int X, int Y)
        {
            array = new Cell[X, Y];
        }

        void initialize()
        {
            for (int i = 0; i < array.GetLength(0);i++)
            {
                for (int j = 0; i< array.GetLength(1); j++)
                {

                }
            }
        }
    }
}
