using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Draw.src.SearchAlgorithms
{
    class BreadthFirstSearchWithContainSearch : SearchAlg
    {

        Graph graph = null;
        String firstNode, secondNode;
        static bool firstNodeCheked = false;
        static bool secondNodeCheked = false;
        static String outputString = "";
       // static String finalNode = "";

        public BreadthFirstSearchWithContainSearch(Graph g,String firstNode, String secondNode)
        {
            this.graph = g;
            this.firstNode = firstNode;
            this.secondNode = secondNode;
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
            List<Node> queue = new List<Node>();
            queue.Add(startNode);

            while (queue.Count() != 0)
            {

                Node temp = queue[0];
                queue.Remove(temp);
                outputString = outputString+"Tested node is: " + temp.MyName + " | Depth: " + temp.depth + Environment.NewLine;

                if (temp.MyName.Equals(endName) && firstNodeCheked == true&&secondNodeCheked==true)
                {
                    Microsoft.VisualBasic.Interaction.MsgBox("HAVE A PATH"+ Environment.NewLine + outputString);
                    return true;
                }
                if (temp.MyName.Equals(firstNode))
                {
                    firstNodeCheked = true;
                }
                if (temp.MyName.Equals(secondNode))
                {
                    secondNodeCheked = true;   
                }

                temp.tested = true;
                graph.setDepthValue(temp);
                temp.sortByLinkLenght();

                foreach (Link l in temp.links)
                {
                    Node relatedNode = myMap[l.NodeTwoName];
                    if (!relatedNode.tested)
                    {
                        queue.Add(relatedNode);
                    }
                }

                temp.expanded = true;
            }//end while
            return false;
        }//end search
    }
}
