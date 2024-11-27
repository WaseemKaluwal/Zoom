using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoom
{
    public partial class Form1 : Form
    {
        int scaleFactor = 5;
        float constant = 1.7f;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            pictureBox1.Height += Convert.ToInt32(scaleFactor / constant);
            pictureBox1.Width += scaleFactor;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            pictureBox1.Height -= Convert.ToInt32(scaleFactor / constant);
            pictureBox1.Width -= scaleFactor;
        }
    }
}
