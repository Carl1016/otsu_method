using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segmentation_and_Recognition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog filename = new OpenFileDialog();
            if (filename.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = filename.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Color R;
            Color G;
            Color B;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Bitmap colorimage = new Bitmap(@textBox1.Text);
            Bitmap grey_image=grey(colorimage);//轉灰階

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = grey_image;
        }
        private Bitmap grey(Bitmap bm1)
        {
            int height = bm1.Height;
            int weight = bm1.Width;
            for (int i = 0; i <= weight - 1; i++)
            {
                for (int j = 0; j <= height - 1; j++)
                {
                    Color c1 = bm1.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int average = (r1 + g1 + b1) / 3;
                    bm1.SetPixel(i, j, Color.FromArgb(average, average, average));
                }             
            }
            return (bm1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
