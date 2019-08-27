using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{   [Serializable]
    public class Link:Shape
    {
        public String NodeOneName,NodeTwoName;
        public float lenght;
        public bool isTwoWay=false;

        public Link(String name1,String name2)
        {
            this.NodeOneName = name1;
            this.NodeTwoName = name2;
        }

        public Link(String name1,String name2, float lenght)
        {
            this.NodeOneName = name1;
            this.NodeTwoName = name2;
            this.lenght = lenght;
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), 5);
            pen.StartCap = LineCap.ArrowAnchor;
            grfx.DrawLine(pen, MainForm.MyGraph.getNodeLocation(NodeOneName) , MainForm.MyGraph.getNodeLocation(NodeTwoName));
            grfx.DrawString(lenght.ToString(), new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point), Brushes.Red, new PointF((MainForm.MyGraph.getNodeLocation(NodeOneName).X+ MainForm.MyGraph.getNodeLocation(NodeTwoName).X)/2, (MainForm.MyGraph.getNodeLocation(NodeOneName).Y + MainForm.MyGraph.getNodeLocation(NodeTwoName).Y)/2));

        }
    }
}
