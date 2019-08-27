using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Draw
{
   [Serializable]
    public class LineShape : Shape
    {
        

        #region Constructor

        public LineShape(RectangleF rect1,RectangleF rect2) : base(rect1)
        {
        }

        public LineShape(LineShape line) : base(line)
        {
        }
        public override string ShapeType()
        {
            return "line";

        }
       
        public LineShape(PointF x, PointF y,LineShape line)//angle point 1 & 2
        {
            PointF s=new Point(Convert.ToInt32(x.X), Convert.ToInt32(x.Y));
            PointF f = new Point(Convert.ToInt32(y.X), Convert.ToInt32(y.Y));
            PointF C = new Point(10, 10);//angle point 2
            C.X = x.X;
            C.Y = y.Y - x.Y;
            PointF B = new Point(10, 10);//angle point 3
            B.X = y.X - x.X;
            B.Y = y.Y;
            float width = B.X;
            float height = C.Y;

            line = new LineShape(new Rectangle(Convert.ToInt32(s.X), Convert.ToInt32(s.Y), Convert.ToInt32(B.X), Convert.ToInt32(C.Y)),
                new Rectangle(Convert.ToInt32(f.X), Convert.ToInt32(f.Y), Convert.ToInt32(B.X), Convert.ToInt32(C.Y)));
            DialogProcessor.ShapeList.Add(line);
        }

        #endregion
      

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {
                return true;
            }
            
            return false;
        }

      
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillRectangle(new SolidBrush(Color.FromArgb((OpacityLvl), FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawLine(new Pen(Color.Black), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
        }
    }
}
