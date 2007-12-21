using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Core;

namespace KmlSuperOverlay
{
    public class AnchorSelectCtrl : Control
    {
        public event GenericEventHandler<ContentAlignment> AnchorPosChanged;
        RectangleF tl, tc, tr, ml, mc, mr, bl, bc, br;

        private ContentAlignment m_AnchorPos = ContentAlignment.TopLeft;
        public ContentAlignment AnchorPos
        {
            get
            {
                return m_AnchorPos;
            }
            set
            {
                m_AnchorPos = value;
                if (AnchorPosChanged != null)
                {
                    AnchorPosChanged(this, new GenericEventArgs<ContentAlignment>(m_AnchorPos));
                }
                Invalidate();
            }
        }

        private SizeF m_GapSize = new SizeF(3, 3);
        public SizeF GapSize
        {
            get
            {
                return m_GapSize;
            }
            set
            {
                m_GapSize = value;
                Invalidate();
            }
        }

        private Color m_HighlightColor;
        public Color HighlightColor
        {
            get
            {
                return m_HighlightColor;
            }
            set
            {
                m_HighlightColor = value;
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (new Region(tl).IsVisible(e.Location))
            {
                AnchorPos = ContentAlignment.TopLeft; return;
            }
            if (new Region(tc).IsVisible(e.Location))
            {
                AnchorPos = ContentAlignment.TopCenter; return;
            }
            if (new Region(tr).IsVisible(e.Location))
            {
                AnchorPos = ContentAlignment.TopRight; return;
            }

            if (new Region(ml).IsVisible(e.Location))
            {
                AnchorPos = ContentAlignment.MiddleLeft; return;
            }
            if (new Region(mc).IsVisible(e.Location))
            {
                AnchorPos = ContentAlignment.MiddleCenter; return;
            }
            if (new Region(mr).IsVisible(e.Location))
            {
                AnchorPos = ContentAlignment.MiddleRight; return;
            }

            if (new Region(bl).IsVisible(e.Location))
            {
                AnchorPos = ContentAlignment.BottomLeft; return;
            }
            if (new Region(bc).IsVisible(e.Location))
            {
                AnchorPos = ContentAlignment.BottomCenter; return;
            }
            if (new Region(br).IsVisible(e.Location))
            {
                AnchorPos = ContentAlignment.BottomRight; return;
            }

            base.OnMouseClick(e);
        }        

        protected override void OnPaint(PaintEventArgs e)
        {
            SizeF bs = new SizeF(((float)Width - 1 - GapSize.Width * 2) / 3, ((float)Height - 1 - GapSize.Height * 2) / 3);
            float wdInc = bs.Width + GapSize.Width;
            float htInc = bs.Height + GapSize.Height;

            tl = new RectangleF(0, 0, bs.Width, bs.Height);
            tc = new RectangleF(wdInc, 0, bs.Width, bs.Height);
            tr = new RectangleF(wdInc * 2, 0, bs.Width, bs.Height);

            ml = new RectangleF(0, htInc, bs.Width, bs.Height);
            mc = new RectangleF(wdInc, htInc, bs.Width, bs.Height);
            mr = new RectangleF(wdInc * 2, htInc, bs.Width, bs.Height);

            bl = new RectangleF(0, htInc*2, bs.Width, bs.Height);
            bc = new RectangleF(wdInc, htInc * 2, bs.Width, bs.Height);
            br = new RectangleF(wdInc * 2, htInc * 2, bs.Width, bs.Height);

            DrawRect(e.Graphics, ContentAlignment.TopLeft, tl);
            DrawRect(e.Graphics, ContentAlignment.TopCenter, tc);
            DrawRect(e.Graphics, ContentAlignment.TopRight, tr);
            DrawRect(e.Graphics, ContentAlignment.MiddleLeft, ml);
            DrawRect(e.Graphics, ContentAlignment.MiddleCenter, mc);
            DrawRect(e.Graphics, ContentAlignment.MiddleRight, mr);
            DrawRect(e.Graphics, ContentAlignment.BottomLeft, bl);
            DrawRect(e.Graphics, ContentAlignment.BottomCenter, bc);
            DrawRect(e.Graphics, ContentAlignment.BottomRight, br);

            base.OnPaint(e);
        }

        private void DrawRect(Graphics graphics, ContentAlignment anchor, RectangleF r)
        {
            if (m_AnchorPos == anchor)
            {
                using (Brush hb = new SolidBrush(m_HighlightColor))
                {
                    graphics.FillRectangle(hb, r);
                }
            }
            graphics.DrawRectangle(Pens.Black, Rectangle.Round(r));
        }
    }



   
}
