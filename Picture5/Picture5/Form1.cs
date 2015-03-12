using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture5
{
    public partial class Form1 : Form
    {
        string image;
        string text;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                image = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (text=="" || image=="")
            {
                MessageBox.Show("You must select an image and text file","Error");
                return;
            }
            Bitmap b = new Bitmap(image);
            Graphics g = Graphics.FromImage(b);

            Brush f = new SolidBrush(ControlPaint.Dark(b.GetPixel(100, 100), 0.0f));
            g.DrawString(File.ReadAllText(text), new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), f, new PointF(100, 100));
            pictureBox1.Image = b;
            g.Flush();
        }
    }


}
