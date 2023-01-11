using System;
using System.Drawing;
using System.Windows.Forms;

namespace FR_GA.Programm
{
    public partial class frmShowResult : Form
    {
        Bitmap bmp;
        public frmShowResult(Bitmap bmp)
        {
            InitializeComponent();
            this.bmp = bmp;
        }

        private void frmShowResult_Load(object sender, EventArgs e)
        {
            pictureBoxShowResult.Image = bmp;
        }
    }
}
