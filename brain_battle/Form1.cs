namespace brain_battle
{
    public partial class Form1 : Form
    {
        private Player[] player = new Player[2];
        private Board board;

        public Form1()
        {
            InitializeComponent();
            this.player[0] = new Player(BirdColor.White,0);
            this.player[1] = new Player(BirdColor.Black,420);
            this.board = new Board(210);

            SuspendLayout();
            // 
            // pictureBox1
            // 
            for (int i = 0; i < 9; i++)
            {
                this.SetPictureBox(player[0].hand[i], PbxP1[i], i, 0);
                this.SetPictureBox(player[1].hand[i], PbxP2[i], i, 420);
                this.SetPictureBox(board.cell[i], PbxBoard[i], i, 210);
                //SetPictureBox(PbxBoard, 210, i);
                //player[1].SetPictureBox(PbxP2, i);
            }

            ResumeLayout(false);
        }
        private void SetPictureBox(Bird bird, PictureBox pbx, int i, int pos_x) 
        {
            int x = 64 * (i % 3) + 50 + pos_x;
            int y = 64 * (i / 3) + 50;
            pbx = new PictureBox();

            ((System.ComponentModel.ISupportInitialize)pbx).BeginInit();

            pbx.Image = bird.bmp;
            pbx.BackgroundImage = Resource1.tile;
            pbx.BackgroundImageLayout = ImageLayout.Center;
            pbx.Location = new Point(x, y);
            pbx.Name = "pictureBox1";
            pbx.Size = new Size(62, 62);
            pbx.TabIndex = 0;
            pbx.TabStop = false;
            pbx.Click += bird.PictureBox1_Click;

            Controls.Add(pbx);
            ((System.ComponentModel.ISupportInitialize)pbx).EndInit();

        }
    }
}
