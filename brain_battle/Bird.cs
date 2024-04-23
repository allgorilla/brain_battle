using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brain_battle
{
    enum BirdSize :int
    {
        Small = 0,
        Medium,
        Large,
        Max,
        Invalid
    }

    enum BirdColor:int
    {
        White = 0,
        Black,
        Max,
        Invalid
    }

    internal class Bird
    {
        public Bitmap bmp;
        private BirdSize size;
        private BirdColor color;

        public Bird(BirdColor color, BirdSize size)
        {

            this.color = color;
            this.size = size;

            this.SetImageBmp(color,size);

        }
        private void SetImageBmp(BirdColor color, BirdSize size) 
        {
            Bitmap[,] bmp_array = new Bitmap[(int)BirdColor.Max, (int)BirdSize.Max]
            {
                { Resource1.ws, Resource1.wm, Resource1.wl },
                { Resource1.bs, Resource1.bm, Resource1.bl }
            };

            if (BirdColor.Max < color)
            {
                this.bmp = Resource1.none;
            }
            else if (BirdSize.Max < size)
            {
                this.bmp = Resource1.none;
            }
            else
            {
                this.bmp = bmp_array[(int)color, (int)size];
            }
            this.bmp.MakeTransparent(Color.White);
        }
        public void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
