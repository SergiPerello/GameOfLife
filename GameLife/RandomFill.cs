using GameLife.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLife
{
    class RandomFill : IFillTable
    {
        public void FillTable(Cell[,] Board)
        {
            for (int i = 0; i < Board.GetLength(0); i++)
                for (int j = 0; j < Board.GetLength(1); j++)
                    Board[i, j] = new Cell(GetRandomBoolean());
        }

        public static bool GetRandomBoolean()
        {
            return new Random().Next(100) % 2 == 0;
        }
    }
}
