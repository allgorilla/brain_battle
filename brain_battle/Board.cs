using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brain_battle
{
    internal class Board
    {
        public Bird[] cell = new Bird[9];
        private int pos_x;

        public Board(int pos_x) 
        {
            this.pos_x = pos_x;
            for (int i = 0; i < 9; i++)
            {
                this.cell[i] = new Bird(BirdColor.Invalid, BirdSize.Invalid);
            }
        }

    }
}
