using System;
using System.Windows.Forms;

namespace Image_Editor
{
    public partial class GammaForm : Form
    {
        public int gammaRed = 0;
        public int gammaGreen = 0;
        public int gammaBlue = 0;

        public GammaForm()
        {
            InitializeComponent();
            btnOK.DialogResult = DialogResult.OK;
        }

        private void redGamma_Scroll(object sender, EventArgs e)
        {
            gammaRed = Convert.ToInt32(redGamma.Value);
            redVal.Text = gammaRed.ToString();
        }

        private void greenGamma_Scroll(object sender, EventArgs e)
        {
            gammaGreen = Convert.ToInt32(greenGamma.Value);
            greenVal.Text = gammaGreen.ToString();
        }

        private void blueGamma_Scroll(object sender, EventArgs e)
        {
            gammaBlue = Convert.ToInt32(blueGamma.Value);
            blueVal.Text = gammaBlue.ToString();
        }
    }
}
