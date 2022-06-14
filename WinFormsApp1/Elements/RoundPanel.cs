using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class RoundPanel :Panel
    {
        private int borderRadius = 20;
        private int shadowSize = 0;
        private int shadowVariante = 0;
        private Color shadowColor = Color.White;
        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public int ShadowSize
        {
            get { return shadowSize; }
            set
            {
                shadowSize = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public int ShadowVariante
        {
            get { return shadowVariante; }
            set
            {
                shadowVariante = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public Color ShadowColor
        {
            get { return shadowColor; }
            set
            {
                shadowColor = value;
                this.Invalidate();
            }
        }

        public RoundPanel()
        { }
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);


            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -0, -0);
            int smoothSize = 2;


            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 0))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    // Create solid brush.
                    SolidBrush redBrush = new SolidBrush(Color.Red);


                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);



                }
                if (shadowSize != 0)
                {
                    
                    if (shadowVariante > 0)
                    {
                        Pen pen = new Pen(shadowColor, shadowSize);
                        pevent.Graphics.DrawLine(pen, 0, 0, 0, this.Height - 2);
                        pevent.Graphics.DrawLine(pen, this.Width - 1, 0, this.Width - 1, this.Height - 2);
                        pevent.Graphics.DrawLine(pen, 0, this.Height - 1, this.Width - 1, this.Height - 2);
                    }

                }

            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border

                using (Pen penBorder = new Pen(Color.Black, 0))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);



                }
               


            }
        }
    }
}
