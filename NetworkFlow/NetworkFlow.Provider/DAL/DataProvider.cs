// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataProvider.cs" company="Warsaw University of Technology">
//   Piotr Janaszek
// </copyright>
// <summary>
//   Class responsible for handling writing and reading xml files from disk.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetworkFlow.Provider.DAL
{
    using System.IO;
    using System.Text;
    using System.Xml;

    using NetworkFlow.Provider.BLL;

    /// <summary>
    /// Class responsible for handling writing and reading xml files from disk.
    /// </summary>
    public class DataProvider
    {
        #region Public Methods and Operators

        /// <summary>
        /// The export graph to xml.
        /// </summary>
        /// <param name="graph">
        /// The graph.
        /// </param>
        /// <param name="path">
        /// The path.
        /// </param>
        public void ExportGraphToXml(Graph graph, string path)
        {
            var settings = new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = true };
            using (var xmlWriter = XmlWriter.Create(path, settings))
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("graph");
                xmlWriter.WriteStartElement("vertices");
                foreach (GraphNode node in graph.Nodes)
                {
                    xmlWriter.WriteStartElement("vertex");
                    xmlWriter.WriteElementString("vertexId", node.VertexId);
                    xmlWriter.WriteElementString("mode", GetIntNodeMode(node.NodeMode));
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("edges");
                foreach (GraphNode node in graph.Nodes)
                {
                    foreach (GraphEdge neighbour in node.Neighbours)
                    {
                        xmlWriter.WriteStartElement("edge");
                        xmlWriter.WriteElementString("from", neighbour.NodeFrom.VertexId);
                        xmlWriter.WriteElementString("to", neighbour.NodeTo.VertexId);
                        xmlWriter.WriteElementString("flow", neighbour.Capacity.ToString());
                        xmlWriter.WriteEndElement();
                    }
                }

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }
        }

        /// <summary>
        /// The export results to xml.
        /// </summary>
        /// <param name="graph">
        /// The graph.
        /// </param>
        /// <param name="path">
        /// The path.
        /// </param>
        public void ExportResultsToXml(Graph graph, string path)
        {
            var settings = new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = true };
            using (var xmlWriter = XmlWriter.Create(path, settings))
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("summary");
                xmlWriter.WriteElementString("numberOfNodes", graph.Count.ToString());
                xmlWriter.WriteElementString("numberOfEdges", graph.Edges.ToString());
                xmlWriter.WriteElementString("sourceNode", graph.Source);
                xmlWriter.WriteElementString("sinkNode", graph.Sink);
                xmlWriter.WriteElementString("maximumFlow", graph.MaximumFlow.ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }
        }

        /// <summary>
        /// The load graph from xml.
        /// </summary>
        /// <param name="path">
        /// The path.
        /// </param>
        /// <returns>
        /// Returns Graph object if loading from xml file was successful.
        /// </returns>
        public Graph LoadGraphFromXml(string path)
        {
            var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(fs);
            Graph graph = ParseNodes(xmlDoc);
            return ParseEdges(graph, xmlDoc);
        }

        #endregion

        #region Methods

        /// <summary>
        /// The get int node mode.
        /// </summary>
        /// <param name="mode">
        /// The mode.
        /// </param>
        /// <returns>
        /// Returns string NodeMode.
        /// </returns>
        private static string GetIntNodeMode(int mode)
        {
            string nodeModeStr;
            switch (mode)
            {
                case 0:
                    nodeModeStr = "normal";
                    break;
                case 1:
                    nodeModeStr = "source";
                    break;
                case 2:
                    nodeModeStr = "sink";
                    break;
                default:
                    nodeModeStr = "normal";
                    break;
            }

            return nodeModeStr;
        }

        /// <summary>
        /// The get str node mode.
        /// </summary>
        /// <param name="mode">
        /// The mode.
        /// </param>
        /// <returns>
        /// Returns int NodeMode.
        /// </returns>
        private static int GetStrNodeMode(string mode)
        {
            int nodeMode = 0;
            switch (mode)
            {
                case "normal":
                    nodeMode = 0;
                    break;
                case "source":
                    nodeMode = 1;
                    break;
                case "sink":
                    nodeMode = 2;
                    break;
            }

            return nodeMode;
        }

        /// <summary>
        /// The parse edges.
        /// </summary>
        /// <param name="graph">
        /// The graph.
        /// </param>
        /// <param name="xmlDoc">
        /// The xml doc.
        /// </param>
        /// <returns>
        /// Returns Graph object with added parsed edges.
        /// </returns>
        private static Graph ParseEdges(Graph graph, XmlDocument xmlDoc)
        {
            XmlNodeList xmlEdges = xmlDoc.GetElementsByTagName("edge");
            for (int i = 0; i < xmlEdges.Count; i++)
            {
                XmlNode xmlsNode = xmlEdges[i].ChildNodes.Item(0);
                XmlNode xmleNode = xmlEdges[i].ChildNodes.Item(1);
                XmlNode xmleCapacity = xmlEdges[i].ChildNodes.Item(2);
                if (xmlsNode != null && xmleNode != null && xmleCapacity != null)
                {
                    string xmlsNodeStr = xmlsNode.InnerText;
                    string xmleNodeStr = xmleNode.InnerText;
                    string xmleCapacityStr = xmleCapacity.InnerText;
                    int flow = int.Parse(xmleCapacityStr);
                    GraphNode startNode = graph.Nodes.FindByName(xmlsNodeStr);
                    GraphNode endNode = graph.Nodes.FindByName(xmleNodeStr);
                    graph.AddDirectedEdge(startNode, endNode, flow);
                }
            }

            return graph;
        }

        /// <summary>
        /// The parse nodes.
        /// </summary>
        /// <param name="xmlDoc">
        /// The xml doc.
        /// </param>
        /// <returns>
        /// Returns Graph object with added paresed nodes.
        /// </returns>
        private static Graph ParseNodes(XmlDocument xmlDoc)
        {
            var graph = new Graph();
            XmlNodeList xmlNodes = xmlDoc.GetElementsByTagName("vertex");
            for (int i = 0; i < xmlNodes.Count; i++)
            {
                GraphNode gnode = null;
                XmlNode xmlNode = xmlNodes[i].ChildNodes.Item(0);
                XmlNode xmlNodeMode = xmlNodes[i].ChildNodes.Item(1);
                if (xmlNode != null)
                {
                    string vertexId = xmlNode.InnerText;
                    if (xmlNodeMode != null)
                    {
                        string mode = xmlNodeMode.InnerText;
                        if (!string.IsNullOrEmpty(vertexId) && !string.IsNullOrEmpty(mode))
                        {
                            int nodem = GetStrNodeMode(mode);
                            gnode = new GraphNode(vertexId, nodem);
                        }
                    }
                    else
                    {
                        gnode = new GraphNode(vertexId, 0);
                    }
                }

                if (gnode != null)
                {
                    graph.AddNode(gnode);
                }
            }

            return graph;
        }

        #endregion
    }
}