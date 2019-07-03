using GameLife.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLife
{
    class RandomFill : IFillTable
    {
        public void FillTable(int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    
                }
            }
        }
        public static bool GetRandomBoolean()
        {
            return new Random().Next(100) % 2 == 0;
        }
    }
}
