using System;
using System.Windows.Forms;

namespace Image_Editor
{
    public partial class BrightnessForm : Form
    {
        public int brightness = 0;

        public BrightnessForm()
        {
            InitializeComponent();
            btnOK.DialogResult = DialogResult.OK;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            brightness = Convert.ToInt32(label1.Text);
        }

    }
}
