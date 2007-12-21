using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Core.FileHandling;
using System.IO;
using System.Drawing.Imaging;

namespace KmlSuperOverlay
{
    public partial class Form1 : Form
    {
        Image largeImage;
        Image screenImage;
        int tileSize = 256;
        int maxLev;
        public Form1() {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            progressBar1.Value = 0;
        }

        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            MakeTiles((string)e.Argument);
        }

        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            LoadSave ls = new LoadSave("Image Files", "jpg", "bmp");
            string path = ls.GetLoadPath();
            if (path == null) return;
            largeImage = Image.FromFile(path);
            CalculateLevels();
            MakeScreenImage();
            tilePreviewCtrl1.Image = new Bitmap(screenImage);
        }

        private void CalculateLevels() {
            int maxDim = (int)Math.Max(largeImage.Width, largeImage.Height);
            int lev = 0;
            int numTiles = 1;
            while (maxDim / numTiles > tileSize) {
                lev++;
                numTiles = (int)Math.Pow(2, lev);
            }
            sldLevel.SetRange(1, lev + 1);
        }

        private void MakeScreenImage() {
            Rectangle rl = new Rectangle(0, 0, largeImage.Width, largeImage.Height);
            Rectangle rs;
            if (largeImage.Width > largeImage.Height) {
                rs = new Rectangle(0, 0, 1024, 1024 * largeImage.Height / largeImage.Width);
            } else {
                rs = new Rectangle(0, 0, 1024 * largeImage.Width / largeImage.Height, 1024);
            }
            screenImage = new Bitmap(rs.Width, rs.Height);
            Graphics g = Graphics.FromImage(screenImage);
            g.DrawImage(largeImage, rs, rl, GraphicsUnit.Pixel);
        }

        private void sldLevel_Scroll(object sender, EventArgs e) {
            int level = sldLevel.Value - 1;
            int numTiles = (int)Math.Pow(2, level);
            tilePreviewCtrl1.NumTiles = numTiles;
            int maxDim = (int)Math.Max(largeImage.Width, largeImage.Height);
            lblTileSize.Text = "Tile Size in Original: " + maxDim / numTiles;
        }

        private void btnMake_Click(object sender, EventArgs e) {
            LoadSave ls = new LoadSave("kmz");
            string path = ls.GetSavePath();
            if (path == null) return; 
            maxLev = sldLevel.Value;
            backgroundWorker1.RunWorkerAsync(path);
        }
        private void MakeTiles(string path) {            
            int totTiles = 0;          
            for (int level = 0; level < maxLev; level++) {
                int numTiles = (int)Math.Pow(2, level);
                totTiles += numTiles * numTiles;
            }
            string dir = Path.GetDirectoryName(path);
            PyramidTiler tiler = new PyramidTiler();
            int cnt = 0;           
            for (int level = 0; level < maxLev; level++) {                
                int numTiles = (int)Math.Pow(2, level);
                Image[,] imgs = tiler.GetTiles(largeImage, numTiles, backgroundWorker1, ref cnt, totTiles);
                for (int x = 0; x < numTiles; x++) {
                    for (int y = 0; y < numTiles; y++) {
                        string fname = Path.Combine(dir, level + "_" + x + "_" + y + ".jpg");
                        Image img = imgs[x, y];
                        if (img != null) {
                            img.Save(fname, ImageFormat.Jpeg);
                        }                        
                    }
                }
            }
        }
    }
}