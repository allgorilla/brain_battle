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
            // pictureBox
            // 
            for (int i = 0; i < 9; i++)
            {
                PictureBox pbx1 = board.SetPictureBox(i);
                PictureBox pbx2 = player[0].SetPictureBox(i);
                PictureBox pbx3 = player[1].SetPictureBox(i);

                this.SetPictureBox(pbx1);
                this.SetPictureBox(pbx2);
                this.SetPictureBox(pbx3);
            }

            ResumeLayout(false);
        }
        private void SetPictureBox(PictureBox pbx) 
        {
            ((System.ComponentModel.ISupportInitialize)pbx).BeginInit();
            Controls.Add(pbx);
            ((System.ComponentModel.ISupportInitialize)pbx).EndInit();
        }
    }
}
