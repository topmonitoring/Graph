using System;
using System.Drawing;

namespace Draw
{
	/// <summary>
	/// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
	/// </summary>
     [Serializable]
	public class RectangleShape : Shape
	{
		#region Constructor
		
		public RectangleShape(RectangleF rect) : base(rect)
		{
        }
		
		public RectangleShape(RectangleShape rectangle) : base(rectangle)
		{
        }

        public RectangleShape(RectangleF rectangle,float x,float y) : base(rectangle)
        { 
        }

        public override string ShapeType()
        {
            return "rectangle";
          
        }

        public RectangleShape(PointF x, PointF y,RectangleShape rect)//angle point 1 & 4
        {
            PointF C = new Point(10, 10);//angle point 2
            C.X = x.X;
            C.Y = y.Y - x.Y;
            PointF B = new Point(10, 10);//angle point 3
            B.X = y.X - x.X;
            B.Y = y.Y;
            float width = B.X;
            float height = C.Y;

            if (width > 0 && height < 0)
            {
                height = height * -1;
                rect = new RectangleShape(new Rectangle(Convert.ToInt32(y.X - width), Convert.ToInt32(y.Y), Convert.ToInt32(width), Convert.ToInt32(height)));
                width = 0;
                height = 0;
            }
            else if (width < 0 && height > 0)
            {
                width = width * -1;
                rect = new RectangleShape(new Rectangle(Convert.ToInt32(y.X), Convert.ToInt32(y.Y - height), Convert.ToInt32(width), Convert.ToInt32(height)));
                width = 0;
                height = 0;
            }
            else if (width < 0 && height < 0)
            {
                width = width * -1;
                height = height * -1;
                rect = new RectangleShape(new Rectangle(Convert.ToInt32(y.X), Convert.ToInt32(y.Y), Convert.ToInt32(width), Convert.ToInt32(height)));
                width = 0;
                height = 0;
            }
            else
            {
                rect = new RectangleShape(new Rectangle(Convert.ToInt32(x.X), Convert.ToInt32(x.Y), Convert.ToInt32(width), Convert.ToInt32(height)));
                Console.Out.WriteLine(" "+width+" "+height);
                width = 0;
                height = 0;
            }
            DisplayProcessor.ShapeList.Add(rect);
        }

        #endregion

        /// <summary>
        /// Проверка за принадлежност на точка point към правоъгълника.
        /// В случая на правоъгълник този метод може да не бъде пренаписван, защото
        /// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
        /// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
        /// елемента в този случай).
        /// </summary>
        public override bool Contains(PointF point)
		{
			if (base.Contains(point))
				// Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
				// В случая на правоъгълник - директно връщаме true
				return true;
			else
				// Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
				return false;
		}
        
        public void rotateThatBich()
        {
       /*     Polyline polyline2 = new Polyline();
            polyline2.Points = polyline1.Points;
            polyline2.Stroke = Brushes.Blue;
            polyline2.StrokeThickness = 10;

            // Create a RotateTransform to rotate
            // the Polyline 45 degrees about the
            // point (25,50).
            RotateTransform rotateTransform2 =
                new RotateTransform(45);
            rotateTransform2.CenterX = 25;
            rotateTransform2.CenterY = 50;
            polyline2.RenderTransform = rotateTransform2;

            // Create a Canvas to contain the Polyline.
            Canvas canvas2 = new Canvas();
            canvas2.Width = 200;
            canvas2.Height = 200;
            Canvas.SetLeft(polyline2, 75);
            Canvas.SetTop(polyline2, 50);
            canvas2.Children.Add(polyline2); */
        }
        

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);
			
			grfx.FillRectangle(new SolidBrush(Color.FromArgb((OpacityLvl), FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawRectangle(new Pen(Color.Black), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
		}
	}
}
