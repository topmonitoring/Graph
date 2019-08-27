using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace Draw.src.Model
{      [Serializable]
    public class Node :ElipseShape
    {
        String weight;

        public List<Link> links = new List<Link>();

        Node parent;
        public int depth;
        public Boolean tested=false;
        public Boolean expanded;

        public void setWeight(String w)
        {
            weight = w;
        }
        public  override String getWeight()
        {
            return weight;
        }

        public override string ShapeType()
        {
            return "node";
        }

        public void addLink(Link link)
        {
            links.Add(link);
        }

        public Node(RectangleF rect, String weight) : base(rect)
        {
            this.weight = weight;
            reset();
        }

        public Node(RectangleShape rectangle, String weight) : base(rectangle)
        {
            this.weight = weight;
            reset();
        }

        public Node(RectangleF rectangle, float x, float y, String weight) : base(rectangle, x, y)
        {
            this.weight = weight;
            reset();
        }

        public Node(PointF x, PointF y, ElipseShape elp, String weight) : base(x, y, elp)
        {
            this.weight = weight;
            reset();
        }

        public void reset()
        {
            parent = null;
            depth = 0;
            tested = false;
            expanded = false;
        }

        public void sortByLinkLenght()
        {
            links.Sort((Link l1,Link  l2) => l1.lenght.CompareTo(l2.lenght));
        }
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);
            grfx.FillEllipse(new SolidBrush(Color.FromArgb((OpacityLvl), FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            // grfx.DrawString(text1, new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, Brushes.Black, rectF1);
            grfx.DrawEllipse(new Pen(Color.Black), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawString(weight, new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point), Brushes.Red, new PointF(this.Location.X+Width / 3, this.Location.Y+Width / 3));
            
        }

    }
}
