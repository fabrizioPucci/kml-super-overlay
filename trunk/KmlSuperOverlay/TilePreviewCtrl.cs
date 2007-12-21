using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace KmlSuperOverlay
{
    public class TilePreviewCtrl : Control
    {
        public TilePreviewCtrl() {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        private Rectangle rImage;
        private Image m_Image;
        public Image Image {
            get {
                return m_Image;
            }
            set {
                m_Image = value;
                if (m_Image == null) return;
                rImage = new Rectangle(0, 0, m_Image.Width, m_Image.Height);
                Invalidate();
            }
        }

        private int m_NumTiles = 1;
        public int NumTiles {
            get {
                return m_NumTiles;
            }
            set {
                m_NumTiles = (int)Math.Max(1, value);
                Invalidate();
            }
        }

        private Color m_EmptyColor = Color.Magenta;
        public Color EmptyColor {
            get {
                return m_EmptyColor;
            }
            set {
                m_EmptyColor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e) {
            if (m_Image == null) return;
            int numTiles = m_NumTiles;
            int maxDim;
            float aspectPb = (float)Width / (float)Height;
            float aspectIm = (float)m_Image.Width / (float)m_Image.Height;
            Rectangle rs;
            if (aspectIm > aspectPb) {
                maxDim = Width;
                rs = new Rectangle(0, 0, Width, Width * m_Image.Height / m_Image.Width);
            } else {
                maxDim = Height;
                rs = new Rectangle(0, 0, Height * m_Image.Width / m_Image.Height, Height);
            }
            using (Brush b = new SolidBrush(m_EmptyColor)) {
                e.Graphics.FillRectangle(b, new Rectangle(0, 0, maxDim, maxDim));
            }
            e.Graphics.DrawImage(m_Image, rs, rImage, GraphicsUnit.Pixel);
            float tileSize = (float)maxDim / (float)numTiles;
            for (int w = 0; w < numTiles + 1; w += 1) {
                int wd = (int)((float)w * tileSize);
                e.Graphics.DrawLine(Pens.Black, new Point(wd, 0), new Point(wd, maxDim));
            }
            for (int h = 0; h < numTiles + 1; h += 1) {
                int ht = (int)((float)h * tileSize);
                e.Graphics.DrawLine(Pens.Black, new Point(0, ht), new Point(maxDim, ht));
            }
            base.OnPaint(e);
        }
    }
}
