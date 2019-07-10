using System;
using System.Collections.Generic;
using System.Text;

namespace GameLife.Interfaces
{
    public interface IOutput
    {
        void DisplayBoard(Cell[,] Board, char AliveSymbol, char DeadSymbol);
    }
}
