using System;
using System.Drawing;

namespace Draw
{
    /// <summary>
    /// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
    /// </summary>
    [Serializable]
    public class ElipseShape : Shape
    {
        

        public ElipseShape(RectangleF rect) : base(rect)
        {
        }

        public ElipseShape(RectangleShape rectangle) : base(rectangle)
        {
        }
        public ElipseShape(RectangleF rectangle,float x,float y) : base(rectangle)
        {
        }
        public override string ShapeType()
        {
            return "elipse";

        }
        public ElipseShape(PointF x, PointF y, ElipseShape elp)//angle point 1 & 4
        {
            
            DisplayProcessor.ShapeList.Add(elp);
        }

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {
                float a = Width / 2;
                float b = Height / 2;
                float xc = Location.X + a;
                float yc = Location.Y + b;
                return Math.Pow((point.X - xc) / a, 2) + Math.Pow((point.Y - yc) / b, 2) - 1 <= 0;
            }

         
            return false;
        }

        
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);
            grfx.FillEllipse(new SolidBrush(Color.FromArgb((OpacityLvl), FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            //grfx.DrawEllipse(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(new Pen(Color.Black), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
        }
    }
}
