using System;
using System.Collections.Generic;
using System.Text;

namespace GameLife
{
    public class Cell
    {
        List<Cell> Neighbours;
        public bool Alive { get; set; }
        public Cell(bool alive)
        {
            this.Alive = alive;
        }
    }
}
