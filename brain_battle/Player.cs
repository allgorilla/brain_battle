using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brain_battle
{
    internal class Player
    {
        public Bird[] hand = new Bird[9];
        private int pos_x;
        private BirdColor color;
        private BirdSize[] size_array = new BirdSize[9]
        {
            BirdSize.Small,
            BirdSize.Small,
            BirdSize.Small,
            BirdSize.Medium,
            BirdSize.Medium,
            BirdSize.Medium,
            BirdSize.Large,
            BirdSize.Large,
            BirdSize.Invalid
        };

        public Player(BirdColor color, int pos_x)
        {   
            this.pos_x = pos_x;
            this.color = color;
            for (int i = 0; i < 9; i++)
            {
                this.hand[i] = new Bird(color, size_array[i]);
            }

            this.color = color;
        }
        public PictureBox SetPictureBox(int idx)
        {
            PictureBox pbx_tmp = this.hand[idx].SetPictureBox(idx, this.pos_x);
            return pbx_tmp;
        }
    }
}
