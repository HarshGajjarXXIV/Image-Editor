using System;
using System.Drawing;
using System.Windows.Forms;

namespace Image_Editor
{
    public partial class MainWindow : Form
    {
        Bitmap orignalImg;
        Bitmap copyImg;
        Bitmap[] imgState = new Bitmap[10];
        int undoPos = 0;
        int brightness = 0;
        int contrast = 0;
        int gammaRed = 0;
        int gammaGreen = 0;
        int gammaBlue = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image File (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";


            if (DialogResult.OK == openFile.ShowDialog())
                this.picBox.Image = new Bitmap(openFile.FileName);

            if (picBox.Image != null)
            {
                var imgSize = picBox.Image.Size;
                var picBoxSize = picBox.ClientSize;

                if (imgSize.Width > picBoxSize.Width || imgSize.Height > picBoxSize.Height)
                    picBox.SizeMode = PictureBoxSizeMode.Zoom;
                else
                    picBox.SizeMode = PictureBoxSizeMode.CenterImage;

                orignalImg = new Bitmap((Bitmap)this.picBox.Image);
            }  
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(picBox.Image != null)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Image File (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";

                if (DialogResult.OK == saveFile.ShowDialog())
                    picBox.Image.Save(saveFile.FileName);
            }
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picBox.Image != null)
            {
                this.Cursor = Cursors.WaitCursor;
                StoreBitmap();
                ImageProcessing.ConvertToGray(copyImg);
                this.picBox.Image = copyImg;
                this.Cursor = Cursors.Default;
            }
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picBox.Image != null)
            {
                this.Cursor = Cursors.WaitCursor;
                StoreBitmap();
                ImageProcessing.ConvertToInvert(copyImg);
                this.picBox.Image = copyImg;
                this.Cursor = Cursors.Default;
            }
        }

        private void redFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picBox.Image != null)
            {
                this.Cursor = Cursors.WaitCursor;
                StoreBitmap();
                ImageProcessing.RedFilter(copyImg);
                this.picBox.Image = copyImg;
                this.Cursor = Cursors.Default;
            }
        }

        private void greenFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picBox.Image != null)
            {
                this.Cursor = Cursors.WaitCursor;
                StoreBitmap();
                ImageProcessing.GreenFilter(copyImg);
                this.picBox.Image = copyImg;
                this.Cursor = Cursors.Default;
            }
        }

        private void blueFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picBox.Image != null)
            {
                this.Cursor = Cursors.WaitCursor;
                StoreBitmap();
                ImageProcessing.BlueFilter(copyImg);
                this.picBox.Image = copyImg;
                this.Cursor = Cursors.Default;
            }
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picBox.Image != null)
            {
                BrightnessForm bForm = new BrightnessForm();
                if (bForm.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    this.brightness = bForm.brightness;
                    StoreBitmap();
                    ImageProcessing.SetBrightness(copyImg, brightness);
                    this.picBox.Image = copyImg;
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picBox.Image != null)
            {
                ContrastForm cForm = new ContrastForm();
                if (cForm.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    this.contrast = cForm.contrast;
                    StoreBitmap();
                    ImageProcessing.SetContrast(copyImg, contrast);
                    this.picBox.Image = copyImg;
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void gammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picBox.Image != null)
            {
                GammaForm gForm = new GammaForm();
                if (gForm.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    this.gammaRed = gForm.gammaRed;
                    this.gammaGreen = gForm.gammaGreen;
                    this.gammaBlue = gForm.gammaBlue;
                    StoreBitmap();
                    ImageProcessing.SetGamma(copyImg, gammaRed, gammaGreen, gammaBlue);
                    this.picBox.Image = copyImg;
                    this.Cursor = Cursors.Default;
                }
            }
        }


        private void rotateRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picBox.Image != null)
            {
                this.Cursor = Cursors.WaitCursor;
                StoreBitmap();
                ImageProcessing.RotateRight(copyImg);
                this.picBox.Image = copyImg;
                this.Cursor = Cursors.Default;
            }
        }

        private void rotateLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picBox.Image != null)
            {
                this.Cursor = Cursors.WaitCursor;
                StoreBitmap();
                ImageProcessing.RotateLeft(copyImg);
                this.picBox.Image = copyImg;
                this.Cursor = Cursors.Default;
            }
        }

        private void flipHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picBox.Image != null)
            {
                this.Cursor = Cursors.WaitCursor;
                StoreBitmap();
                ImageProcessing.FlipHorizontal(copyImg);
                this.picBox.Image = copyImg;
                this.Cursor = Cursors.Default;
            }
        }

        private void flipVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picBox.Image != null)
            {
                this.Cursor = Cursors.WaitCursor;
                StoreBitmap();
                ImageProcessing.FlipVertical(copyImg);
                this.picBox.Image = copyImg;
                this.Cursor = Cursors.Default;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picBox.Image != null)
            {
                if(undoPos == 0 && imgState[9] != null)
                {
                    this.picBox.Image = imgState[9];
                    undoPos = 9 - 1;
                }
                else if(undoPos > 0)
                {
                    this.picBox.Image = imgState[undoPos - 1];
                    undoPos -= 1;
                }
                    
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picBox.Image != null)
            {
                this.Cursor = Cursors.WaitCursor;
                this.picBox.Image = orignalImg;
                this.Cursor = Cursors.Default;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void StoreBitmap()
        {
            imgState[undoPos] = new Bitmap((Bitmap)this.picBox.Image);
            if (undoPos == 9)
                undoPos = 0;
            else
                undoPos += 1;
            copyImg = new Bitmap((Bitmap)this.picBox.Image);
        }
    }
}
