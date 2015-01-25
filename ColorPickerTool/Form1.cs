using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPickerTool
{
    public partial class Form1 : Form
    {
        Bitmap bitm = new Bitmap(1, 1);
        Graphics gr;
        public Form1()
        {
            InitializeComponent();
            gr = Graphics.FromImage(bitm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gr.CopyFromScreen(MousePosition.X, MousePosition.Y, 0, 0, new Size(1, 1));
            var color=bitm.GetPixel(0,0);
            label1.Text = color.R.ToString();
            trackBar1.Value = color.R;
            label2.Text = color.G.ToString();
            trackBar2.Value = color.G;
            label3.Text = color.B.ToString();
            trackBar3.Value = color.B;
        }
    }
}
