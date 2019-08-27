using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Draw.src.SearchAlgorithms
{
    class BreadthFirstSearch : SearchAlg
    {

        Graph graph = null;

        public BreadthFirstSearch(Graph g)
        {
            this.graph = g;
            graph.resetGraph();         
        }

        public bool search(string startName, string endName)  
        {

            Dictionary<String, Node> myMap = MainForm.MyGraph.getMap();

            if (!myMap.ContainsKey(startName) || !myMap.ContainsKey(endName))
            {
                return false;
            }

            Node startNode = myMap[startName];
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(startNode);
            String outputString = "HAVE A PATH"+Environment.NewLine;
            Node temp =new Node(new System.Drawing.RectangleF(0,0,0,0),"");

            while (queue.Count()!=0)
            {
                temp = queue.First();
                queue.Dequeue();
                outputString += ("Tested node is: " + temp.MyName + " | Depth: " + temp.depth + Environment.NewLine); 

                if (temp.MyName.Equals(endName))
                {
                    Microsoft.VisualBasic.Interaction.MsgBox(outputString);
                    return true;
                }

                temp.tested = true;
                graph.setDepthValue(temp);
                temp.sortByLinkLenght();

                foreach (Link l in temp.links)
                {
                    Node relatedNode = MainForm.MyGraph.GetObject(l.NodeTwoName); 
                    if (!relatedNode.tested)
                    {
                        queue.Enqueue(relatedNode);
                    }
                }

                temp.expanded = true;
            }//end while
            return false;
        }//end search
    }
}
