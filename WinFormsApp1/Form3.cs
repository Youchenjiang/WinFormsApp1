using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void RotateFormCenter(PictureBox pb, float angle)
        {
            Image img = pb.Image;
            //int newWidth = Math.Max(img.Height, img.Width);
            int newWidth = Math.Max(141, 99);
            Bitmap bmp = new Bitmap(newWidth, newWidth);
            Graphics g = Graphics.FromImage(bmp);
            Matrix x = new Matrix();
            PointF point = new PointF(img.Width / 2f, img.Height / 2f);
            x.RotateAt(angle, point);
            g.Transform = x;
            g.DrawImage(img, 0, 0);
            g.Dispose();
            img = bmp;
            pb.Image = img;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
            //pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //button1 can't select*/
            button1.Enabled = false;
            System.Threading.Thread.Sleep(100);
            RotateFormCenter(pictureBox1, 330);
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(1000);
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(500);
            RotateFormCenter(pictureBox1, -60);
            pictureBox1.Refresh();
            button1.Enabled = true;
        }
    }
}
