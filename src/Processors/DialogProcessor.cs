using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;
using System.Collections;
using System.Xml;
using System.Runtime.Serialization;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using Draw.src.Model;

namespace Draw
{
    [Serializable()]
  
    public class DialogProcessor : DisplayProcessor
    {
        #region Constructor
        
        public DialogProcessor()
        {
        }

        #endregion

        /// <summary>
        /// Избран елемент.
        /// </summary>
        private List<Shape> selection = new List<Shape>();
        public List<Shape> Selection
        {
            get { return selection; }
            set { selection = value; }
        }


        /// <summary>
        /// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
        /// </summary>
        private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}
		
		/// <summary>
		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}



        public void AddToShapeList(Shape item)
        {
            ShapeList.Add(item);
        }
        public void RemoveFromShapeList(Shape item)
        {
            ShapeList.Remove(item);
        }



        public void AddRectangle(PointF x, PointF y)
        {
            RectangleShape rect = new RectangleShape(new Rectangle(0, 0, 0, 0));
            RectangleShape Myrect = new RectangleShape(x,y,rect);
        }
        public void AddElipse(PointF x, PointF y)
        {
            ElipseShape elip = new ElipseShape(new Rectangle(0, 0, 0, 0));
            ElipseShape Myelip = new ElipseShape(x, y, elip);
        }
        
     
        public void CoppyShape()
        {
            if(Selection!=null)
            {
                Node CopyItem = new Node(new RectangleF(0, 0, 0, 0),"");
                foreach (Shape item in Selection)
                {
                    switch (item.ShapeType())
                    {
                        case "node":
                            String weight =item.getWeight();
                            CopyItem = new Node(new Rectangle(Convert.ToInt32(item.Location.X + 4),
                            Convert.ToInt32(item.Location.Y + 4), Convert.ToInt32(item.Width), Convert.ToInt32(item.Height)),weight);
                            CopyItem.SetOpacity(item.OpacityLvl);
                            CopyItem.FillColor = item.FillColor;
                            String MyNodeName = "Copy of " + item.MyName;
                            CopyItem.SetName(MyNodeName);
                            MainForm.MyGraph.addNodeToMap(MyNodeName,CopyItem);
                            break;

                        default:break;
                    }
                }
                ShapeList.Add(CopyItem);
            }
        }


        public void AddSelection(PointF x, PointF y)//if user click's in empty space starts draw ractangle, then cheks if this rectangle contains item & adds or removes it from Selection 
        {
            PointF C = new Point(10, 10);//angle point 2
            C.X = x.X;
            C.Y = y.Y - x.Y;
            PointF B = new Point(10, 10);//angle point 3
            B.X = y.X - x.X;
            B.Y = y.Y;
            float width = B.X;
            float height = C.Y;

            RectangleShape Selrect = new RectangleShape(new Rectangle(0,0,0,0));

            if (width > 0 && height < 0)
            {
                height = height * -1;
                Selrect = new RectangleShape(new Rectangle(Convert.ToInt32(y.X - width), Convert.ToInt32(y.Y), Convert.ToInt32(width), Convert.ToInt32(height)));
                width = 0;
                height = 0;
            }
            else if (width < 0 && height > 0)
            {
                width = width * -1;
                Selrect = new RectangleShape(new Rectangle(Convert.ToInt32(y.X), Convert.ToInt32(y.Y - height), Convert.ToInt32(width), Convert.ToInt32(height)));
                width = 0;
                height = 0;
            }
            else if (width < 0 && height < 0)
            {
                width = width * -1;
                height = height * -1;
                Selrect = new RectangleShape(new Rectangle(Convert.ToInt32(y.X), Convert.ToInt32(y.Y), Convert.ToInt32(width), Convert.ToInt32(height)));
                width = 0;
                height = 0;
            }
            else
            {
                Selrect = new RectangleShape(new Rectangle(Convert.ToInt32(x.X), Convert.ToInt32(x.Y), Convert.ToInt32(width), Convert.ToInt32(height)));
                Console.Out.WriteLine(" " + width + " " + height);
                width = 0;
                height = 0;
            }
 
            foreach (Shape item in DisplayProcessor.ShapeList) //cheks if the Selrek contains item's in Shhape list & gives them proprty true if so
            {
                float AX = item.Location.X;
                float AY = item.Location.Y;
                float BX = item.Location.X+item.Height;
                float BY = item.Location.Y+item.Width;
                item.ContainsSel = true;

                if (x.X>BX||AX>y.X)
                {
                    item.ContainsSel = false;
                }
                if (x.Y > BY||AY>y.Y)
                {
                    item.ContainsSel = false;
                } 
            }

            foreach(Shape item in ShapeList) //for evry item that contains selection, item-> deslelect & if contains-> item select
            {
                if(item.ContainsSel==true)
                {
                    if(Selection.Contains(item))
                    {
                        Selection.Remove(item);
                    }
                    else
                    {
                        Selection.Add(item);
                    }
                }
            }
            //ShapeList.Remove(Selrect);

            Selrect = new RectangleShape(new Rectangle(0,0,0,0));
            // GC.Collect();
            // GC.WaitForPendingFinalizers();
        }


        public Shape ContainsPoint(PointF point)
		{
			for(int i = ShapeList.Count - 1; i >= 0; i--){
				if (ShapeList[i].Contains(point)){
					return ShapeList[i];
				}	
			}
			return null;
		}

        public void SetColor(Color color)
        {
            if (Selection != null)
            {
                foreach(var item in Selection)
                {
                    item.FillColor = color; //sets color to filcolor
                    item.SetOpacity(244); //sets opacity to max when item is beeing colored
                }
               
            }
        }

        public void ChangeMyPen(Color penColor,float width)
        {
            foreach(Shape item in ShapeList)
            {
                if(Selection.Contains(item))
                {
                    item.SetPen(penColor, width);
                }
            }
        }

        public void SelectAll()
        {
            foreach(Shape item in ShapeList)
            {
                Selection.Add(item);
            }
        }
        public void DeselectAll()
        {
            foreach(Shape item in ShapeList)
            {
                Selection.Remove(item);
            }
        }

        public void ChangeMyOpacity(Double opacity)
        {
            foreach (Shape item in ShapeList)
            {
                if (Selection.Contains(item))
                {
                    item.SetOpacity(opacity);
                }
            }
        }

        public void ChengeMyColorByName(string MyColor)
        {
            foreach (Shape item in ShapeList)
            {
                if (Selection.Contains(item))
                {
                    //MyColor.ToLower();
                    item.FillColor = Color.FromName(MyColor);
                    item.OpacityLvl = 244;
                }
            }
        }

       
        
        

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////
        /// </summary>

      
       
        

        public override void Draw(Graphics grfx)
        {
            base.Draw(grfx);
            foreach (var item in Selection)
            {
                grfx.DrawRectangle(
                    Pens.Black,
                    item.Rectangle.Left - 2,
                    item.Rectangle.Top - 2,
                    item.Width + 4,
                    item.Height + 4);
            }
        }

        public void DeleteShape()
        {
            foreach (var item in Selection)
            {
                ShapeList.Remove(item);
            }
            Selection = new List<Shape>();
        }

        public void TranslateTo(PointF p)
		{
            foreach (var item in Selection)
            {
                item.Location = new PointF(item.Location.X + p.X - lastLocation.X, item.Location.Y + p.Y - lastLocation.Y);
                lastLocation = p;
                
            }


        }

        public void SetShapeName(String name)
        {
            foreach(var item in Selection)
            {
                Node tempNode=MainForm.MyGraph.GetObject(item.MyName);
                MainForm.MyGraph.DeleteNodeFromMap(tempNode.MyName);

                item.SetName(name);
                MainForm.MyGraph.addNodeToMap(name,tempNode);

            }
        }

        public void ChengeMyAngle(float RotationAngle)
        {
            foreach(Shape item in Selection)
            {
                item.angle = RotationAngle;
               // item.Contains(RotationAngle);
            }


        }
    
          
    }

}
