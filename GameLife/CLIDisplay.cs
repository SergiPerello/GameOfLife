using System;
using System.Collections.Generic;
using System.Text;
using GameLife.Interfaces;

namespace GameLife
{
    class CLIDisplay : IOutput
    {
        public void DisplayBoard(Cell[,] Board, char AliveSymbol, char DeadSymbol)
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Console.Write((Board[i,j].Alive ? AliveSymbol : DeadSymbol) + " ");
                }
                Console.WriteLine();
            }
                
        }
    }
}
