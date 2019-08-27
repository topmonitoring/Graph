using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace Draw.src.Model
{
    [Serializable]

    public class Graph :Shape
    {
        public static int br = 0;

        private static Dictionary <String, Node> myMap = new Dictionary<String, Node>();

        public Dictionary< String,Node> getMap()
        {
            return myMap;
        }

        public Node GetObject(string name)
        {
            if (myMap.ContainsKey(name))
                return myMap[name];
            return null;
        }

        public void addNodeToMap(String myNodeName,Node MyNode)
        {
            myMap.Add(myNodeName, MyNode);
        }

        public void DeleteNodeFromMap(String nodeName)
        {
            myMap.Remove(nodeName);
        }

        public void addNode(int x, int y, String weight)
        {
            if (!myMap.ContainsKey(weight))
            {

                Node MyNode = new Node(new RectangleF(x, y, 50, 50), weight);
                
               while(true)
                {
                    String myNodeName = "node " + br.ToString();
                    MyNode.SetName(myNodeName);
                    myMap.Add(myNodeName, MyNode);
                    br++;
                    break;
                }
                DisplayProcessor.ShapeList.Add(MyNode);
            }
            else
            {
                Interaction.MsgBox("Error Node with this name alredy exsists!");
            }
        }//end addNode
        
        public bool HaveMoreThanOneNode()
        {
            if(myMap.Count()>1)
            {
                return true;
            }
            else
                return false;
            
        }

        public void addOneWayLink(String startName, String endName, float l)
        {
            if(startName==endName)
            {
                Interaction.MsgBox("You can't link node with himself");
            }
            else
            if (myMap.ContainsKey(startName) && myMap.ContainsKey(endName))
            {
                Node startNode = myMap[startName];

                Link newLink = new Link(startName,endName, l);
                startNode.addLink(newLink);
                DisplayProcessor.ShapeList.Add(newLink);
            }
        }

        public void addTwoWayLink(String startName, String endName, float l)
        {
            if (startName == endName)
            {
                Interaction.MsgBox("You can't link node with himself");
            }
            else
            if (myMap.ContainsKey(startName) && myMap.ContainsKey(endName))
            {
                Node startNode = myMap[startName];
                Link newLink = new Link(startName, endName, l);
                newLink.isTwoWay = true;
                startNode.addLink(newLink);
                DisplayProcessor.ShapeList.Add(newLink);

                Node endNode = myMap[endName];
                Link newLink2 = new Link(endName,startName, l);
                newLink.isTwoWay = true;
                endNode.addLink(newLink2);
                DisplayProcessor.ShapeList.Add(newLink2);
            }
        }

        public static void SerializeMyMap(String filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite))
            {
                formatter.Serialize(stream, myMap);
                stream.Flush();
                stream.Close();
            }
        }
        public static void Deserialize(String filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite))
            {
                
                myMap = new Dictionary<string, Node>();
                myMap = (Dictionary<String, Node>)formatter.Deserialize(stream);
                

                Dictionary<string, Node>.ValueCollection values = myMap.Values;
                foreach (Node item in values)
                {
                    DisplayProcessor.ShapeList.Add(item);
                }

                foreach (Node item in values)
                {
                    foreach (Link l in item.links)
                    {
                        DisplayProcessor.ShapeList.Add(l);
                    }
                }
                stream.Close();
            }
        }

        public void resetGraph()
        {
            ICollection<Node> nodes = myMap.Values;
            foreach (Node n in nodes)
            {
                n.reset();
            }
        }

        public void setDepthValue(Node node)
        {
            foreach (Link l in node.links)
            {
                Node temp = myMap[l.NodeTwoName];
                if (temp.depth == 0 && !temp.tested)
                {
                    temp.depth = node.depth + 1;
                }
            }
        }
        public override void changeNodeName(String NodeName,String newName)
        {
            if(myMap.ContainsKey(NodeName))
            {
                myMap[NodeName].SetName(newName);
            }
        }

        public PointF getNodeLocation(String node1)

        {
            Node temp =MainForm.MyGraph.GetObject(node1);
            return new PointF(temp.Location.X+temp.Width/2,temp.Location.Y+temp.Width/2);
        }
        

    }
}
