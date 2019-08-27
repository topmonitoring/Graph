using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Draw.src.SearchAlgorithms
{
    class BreadthFirstSearchWithIgnoreCase : SearchAlg
    {

        Graph graph = null;
        int ignoreLink = 0;
        int IgnoreNodeWithWeightGraterThan = 0;

        public BreadthFirstSearchWithIgnoreCase(Graph g, int ignoreLink,int IgnoreNodeWithWeightGraterThan)
        {
            this.ignoreLink = ignoreLink;
            this.IgnoreNodeWithWeightGraterThan = IgnoreNodeWithWeightGraterThan;
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
                Node temp=queue[0];
                queue.Remove(temp);
                outputString =outputString + "Tested node is: " + temp.MyName + " | Depth: " + temp.depth + Environment.NewLine;

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
                    Node relatedNode = myMap[l.NodeTwoName];
                    if (!relatedNode.tested)
                    {
                        if (IgnoreNodeWithWeightGraterThan != 0) //само когато customvalue е различно от 0
                        {
                            switch (ignoreLink)
                            {
                                case 0:
                                    if (Int32.Parse(temp.getWeight()) <= IgnoreNodeWithWeightGraterThan) //ако не игнорира линкове проверява дали е <= от customvalue
                                    {
                                        queue.Add(relatedNode);
                                    }
                                    break;
                                case 1:
                                    if (Int32.Parse(temp.getWeight()) <= IgnoreNodeWithWeightGraterThan && l.isTwoWay == true) //игнорира oneway links проверява дали е <= от customvalue
                                    {
                                        queue.Add(relatedNode);
                                    }
                                    break;
                                case 2:
                                    if (Int32.Parse(temp.getWeight()) <= IgnoreNodeWithWeightGraterThan && l.isTwoWay == false) //игнорира twoway links проверява дали е <= от customvalue
                                    {
                                        queue.Add(relatedNode);
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            switch (ignoreLink)
                            {
                                case 0:
                                        queue.Add(relatedNode);
                                    break;
                                case 1:
                                    if (l.isTwoWay == true) //игнорира oneway links
                                    {
                                        queue.Add(relatedNode);
                                    }
                                    break;
                                case 2:
                                    if (l.isTwoWay == false) //игнорира twoway links
                                    {
                                        queue.Add(relatedNode);
                                    }
                                    break;
                            }
                        }
                        
                    }
                }

                temp.expanded = true;
            }//end while
            return false;
        }//end search
    }
}
