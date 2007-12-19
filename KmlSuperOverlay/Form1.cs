using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Core.FileHandling;

namespace KmlSuperOverlay
{
    public partial class Form1 : Form
    {
        Image largeImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSave ls = new LoadSave("Image Files", "jpg", "bmp");
            string path = ls.GetLoadPath();
            if (path == null) return;
            largeImage = Image.FromFile(path);
            UpdatePBPyramid();  
        }

        private void UpdatePBPyramid()
        {
            Rectangle rl = new Rectangle(0, 0, largeImage.Width, largeImage.Height);
            Rectangle rs = new Rectangle(0, 0, pbPyramid.Width, pbPyramid.Height);

            Bitmap screenImage = new Bitmap(rs.Width, rs.Height);
            Graphics g = Graphics.FromImage(screenImage);
            g.DrawImage(largeImage, rs, rl, GraphicsUnit.Pixel);
            pbPyramid.Image = screenImage;
            pbPyramid.Paint += new PaintEventHandler(pbPyramid_Paint);    
        }

        void pbPyramid_Paint(object sender, PaintEventArgs e)
        {
            int level = sldLevel.Value;
            int numW = largeImage.Width / (256 * level);
            int numH = largeImage.Height / (256 * level);
            int tileW = pbPyramid.Width / numW;
            int tileH = pbPyramid.Height / numH;
            for (int w = 0; w < pbPyramid.Width; w += tileW)
            {
                e.Graphics.DrawLine(Pens.Black, new Point(w, 0), new Point(w, pbPyramid.Height));
            }
            for (int h = 0; h < pbPyramid.Height; h += tileH)
            {
                e.Graphics.DrawLine(Pens.Black, new Point(0, h), new Point(pbPyramid.Width, h));
            }
        }

        private void sldLevel_Scroll(object sender, EventArgs e)
        {
            UpdatePBPyramid();
        }
    }
}