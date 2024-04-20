using System.Windows.Forms;

namespace brain_battle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private PictureBox[] PbxP1 = new PictureBox[9];
        private PictureBox[] PbxP2 = new PictureBox[9];
        private PictureBox[] PbxBoard = new PictureBox[9];

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // Form1
            // 
            SuspendLayout();
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);

            SuspendLayout();
            // 
            // pictureBox1
            // 
            for (int i = 0; i < 9; i++) {
                SetPictureBox(PbxP1, 0, i);
                SetPictureBox(PbxBoard, 210, i);
                SetPictureBox(PbxP2, 420, i);
            }

            ResumeLayout(false);
        }

        private void SetPictureBox(PictureBox[] pbx, int j, int i)
        {
            Bitmap bmp = Resource1.bs;

            pbx[i] = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbx[i]).BeginInit();

            bmp.MakeTransparent(Color.White);
            pbx[i].Image = bmp;
            pbx[i].BackgroundImage = Resource1.tile;
            pbx[i].BackgroundImageLayout = ImageLayout.Center;
            pbx[i].Location = new Point( 50+j+64*(i%3), 50+64*(i/3) );
            pbx[i].Name = "pictureBox1";
            pbx[i].Size = new Size(64, 64);
            pbx[i].TabIndex = 0;
            pbx[i].TabStop = false;
            pbx[i].Click += pictureBox1_Click;

            Controls.Add(pbx[i]);
            ((System.ComponentModel.ISupportInitialize)pbx[i]).EndInit();
        }

        #endregion
    }
}
