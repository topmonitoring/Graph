using Draw.src.Model;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Draw.src.SearchAlgorithms
{
    class GreedyByLenght :SearchAlg
    {
        Graph graph = null;

        public GreedyByLenght(Graph g)
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
            List<Node> queue = new List<Node>();
            queue.Add(startNode);
            String outputString = "HAVE A PATH" + Environment.NewLine;

            while (queue.Count() != 0)
            {

                Node temp = queue[0];
                queue.Remove(temp);
                outputString+=("Tested node is: " + temp.MyName + " | Depth: " + temp.depth+ Environment.NewLine);

                if (temp.MyName.Equals(endName))
                {
                    Interaction.MsgBox(outputString);
                    return true;
                }

                temp.tested = true;

                graph.setDepthValue(temp);
                temp.sortByLinkLenght();

                for (int i = temp.links.Count() - 1; i > -1; i--)
                {
                    Node relatedNode = myMap[temp.links[i].NodeTwoName];
                    if (!relatedNode.tested)
                    {
                        queue.Insert(0, relatedNode); //
                    }
                }

                temp.expanded = true;
            } // end while
            return false;
            
        }// end search
    }
}
