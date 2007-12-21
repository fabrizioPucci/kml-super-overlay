using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace KmlSuperOverlay
{
    public class PyramidTiler
    {
        public float GetTileLength(Image image, int divs) {           

            if (image.Width > image.Height) {
                return (float)image.Width / (float)divs;
            } else {
                return (float)image.Height / (float)divs;
            }
        }

        private int m_TileSize = 256;
        public int TileSize {
            get {
                return m_TileSize;
            }
            set {
                m_TileSize = value;
            }
        }

        public Image[,] GetTiles(Image image, int divs, BackgroundWorker backgroundWorker, ref int cnt, int total) {
            Image[,] ans = new Image[divs, divs];
            float sourceSize = GetTileLength(image, divs);
            for (int x = 0; x < divs; x++) {
                for (int y = 0; y < divs; y++) {
                    backgroundWorker.ReportProgress(100 * cnt++ / total);
                    if (x * sourceSize > image.Width || y * sourceSize > image.Height) {
                        ans[x, y] = null;
                        continue;
                    }
                    Bitmap b = new Bitmap(m_TileSize, m_TileSize);
                    Graphics g = Graphics.FromImage(b);
                    RectangleF sr = new RectangleF(x * sourceSize, y * sourceSize, sourceSize, sourceSize);                    
                    Rectangle dr = new Rectangle(0, 0, m_TileSize, m_TileSize);
                    g.DrawImage(image, dr, Rectangle.Round(sr), GraphicsUnit.Pixel);
                    ans[x, y] = b;                    
                }
            }
            return ans;
        }        
    }
}
