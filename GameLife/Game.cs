using System;
using System.Collections.Generic;
using System.Text;
using GameLife.Interfaces;

namespace GameLife
{
    class Game
    {
        Cell[,] Board;
        IFillTable FillTable;
        IOutput Output;
        public Game(int BoardDimensionX, int BoardDimensionY)
        {
            Board = new Cell[BoardDimensionX, BoardDimensionY];
            new RandomFill().FillTable(Board);
            new CLIDisplay().DisplayBoard(Board,'■','.');
        }

    }
}
