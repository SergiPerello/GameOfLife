using System;
using System.Collections.Generic;
using System.Text;

namespace GameLife
{
    class Cell
    {
        public bool alive { get; set; }
        public Cell(bool alive)
        {
            this.alive = alive;
        }
    }
}
