using System;
using System.Windows.Forms;

namespace Image_Editor
{
    public partial class ContrastForm : Form
    {
        public int contrast = 0;

        public ContrastForm()
        {
            InitializeComponent();
            btnOK.DialogResult = DialogResult.OK;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            contrast = Convert.ToInt32(label1.Text);
        }
    }
}
