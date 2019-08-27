using System;
using System.Drawing;

namespace Draw
{
    /// <summary>
    /// Базовия клас на примитивите, който съдържа общите характеристики на примитивите.
    /// </summary>
    [Serializable]
    public abstract class Shape
    {
        #region Constructors

        public Shape()
        {
        }

        public Shape(RectangleF rect)
        {
            rectangle = rect;
        }
        
        public Shape(Shape shape)
        {
            this.Height = shape.Height;
            this.Width = shape.Width;
            this.Location = shape.Location;
            this.rectangle = shape.rectangle;
            this.FillColor = shape.FillColor;
            this.MyPen = new Pen(Color.Black);

        }
        #endregion
        
        public virtual String ShapeType(){
           return null;
        }

        public bool ContainsSel = false;//used when need to determen if item contains Selection

        public bool IsGrooped = false;
        #region Properties

        /// <summary>
        /// Обхващащ правоъгълник на елемента.
        /// </summary>
        private RectangleF rectangle;		
		public virtual RectangleF Rectangle {
			get { return rectangle; }
			set { rectangle = value; }
		}
		
		/// <summary>
		/// Широчина на елемента.
		/// </summary>
		public virtual float Width {
			get { return Rectangle.Width; }
			set { rectangle.Width = value; }
		}
		
		/// <summary>
		/// Височина на елемента.
		/// </summary>
		public virtual float Height {
			get { return Rectangle.Height; }
			set { rectangle.Height = value; }
		}

        /// <summary>
        /// Горен ляв ъгъл на елемента.
        /// </summary>
        public virtual PointF Location {
			get { return Rectangle.Location; }
			set { rectangle.Location = value; }
		}
		
		/// <summary>
		/// Цвят на елемента.
		/// </summary>
		private Color fillColor;		
		public virtual Color FillColor {
			get { return fillColor; }
			set { fillColor = value; }
		}
		
		#endregion
		

		/// <summary>
		/// Проверка дали точка point принадлежи на елемента.
		/// </summary>
		/// <param name="point">Точка</param>
		/// <returns>Връща true, ако точката принадлежи на елемента и
		/// false, ако не пренадлежи</returns>
        
		public virtual bool Contains(PointF point)
		{
			return Rectangle.Contains(point.X, point.Y);
		}

        public void SetName(string name)
        {
            MyName = name;
        }
       
        public String MyName = "";
        //[NonSerialized]

       // public Pen MyPen = new Pen(Color.Black); //shapeFigure personal pen
 [NonSerialized]
        Pen MyPen;
       

        public void SetPen(Color pencolor,float penWidth) //seting pen
        {
            MyPen = new Pen(pencolor,penWidth);
        }
        public Pen GetPen()
        {
           return MyPen;
        }

        public int OpacityLvl = 0; //opacity lvl from 0 to 244

        public void SetOpacity(double opacity)
        {
            OpacityLvl=Convert.ToInt32(opacity);
        }

        public void Rotate(float rotationAngle)
        {
            angle = rotationAngle;
        }
        public float angle = 0;
        /// <summary>
        /// Визуализира елемента.
        /// </summary>
        /// <param name="grfx">Къде да бъде визуализиран елемента.</param>
        public virtual void DrawSelf(Graphics grfx)
		{
            grfx.RotateTransform(angle);
            // shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);
            grfx.DrawString(MyName, new System.Drawing.Font("Arial", 16), new SolidBrush(Color.Black), Rectangle.X, Rectangle.Y+Rectangle.Height);
        }

        public virtual String getWeight()
        {
           return "";
        }

        public virtual void changeNodeName(String NodeName, String newName)
        {
            
        }
    }
}
