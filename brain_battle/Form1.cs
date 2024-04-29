namespace brain_battle
{
    public partial class Form1 : Form
    {
        private Player[] player = new Player[2];
        private Board board;
        private PictureBox? CurrentPbx = null;

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
                PictureBox? pbx1 = board.SetPictureBox(i);
                PictureBox? pbx2 = player[0].SetPictureBox(i);
                PictureBox? pbx3 = player[1].SetPictureBox(i);

                pbx1.Click += PictureBox_Click;
                pbx2.Click += PictureBox_Click;
                pbx3.Click += PictureBox_Click;

                this.AddControls(pbx1);
                this.AddControls(pbx2);
                this.AddControls(pbx3);
            }

            ResumeLayout(false);
        }
        private void PictureBox_Click(object? sender, EventArgs e)
        {
            PictureBox? pbx_tmp = sender as PictureBox;

            if (CurrentPbx != null) {
                CurrentPbx.BorderStyle = BorderStyle.None;
                CurrentPbx.BackgroundImage = Resource1.tile;
            }

            pbx_tmp.BorderStyle = BorderStyle.FixedSingle;
            pbx_tmp.BackgroundImage = Resource1.darken;
            CurrentPbx = pbx_tmp;

        }
        private void AddControls(PictureBox pbx) 
        {
            ((System.ComponentModel.ISupportInitialize)pbx).BeginInit();
            Controls.Add(pbx);
            ((System.ComponentModel.ISupportInitialize)pbx).EndInit();
        }
    }
}
