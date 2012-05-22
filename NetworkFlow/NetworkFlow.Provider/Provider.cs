// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Provider.cs" company="Warsaw University of Technology">
//   Piotr Janaszek
// </copyright>
// <summary>
//   The provider.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetworkFlow.Provider
{
    using NetworkFlow.Provider.BLL;
    using NetworkFlow.Provider.DAL;

    /// <summary>
    /// The provider.
    /// </summary>
    public class Provider
    {
        #region Constants and Fields

        /// <summary>
        /// The graph.
        /// </summary>
        private Graph graph;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets NetworkFlowGraph.
        /// </summary>
        public Graph NetworkFlowGraph
        {
            get
            {
                return this.graph;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The add directed edge.
        /// </summary>
        /// <param name="from">
        /// The from.
        /// </param>
        /// <param name="to">
        /// The to.
        /// </param>
        /// <param name="flow">
        /// The flow.
        /// </param>
        public void AddDirectedEdge(string from, string to, int flow)
        {
            if (this.graph == null)
            {
                return;
            }

            GraphNode fromNode = this.graph.Nodes.FindByName(@from);
            GraphNode toNode = this.graph.Nodes.FindByName(to);
            if (fromNode != null && toNode != null)
            {
                this.graph.AddDirectedEdge(fromNode, toNode, flow);
            }
        }

        /// <summary>
        /// The add node.
        /// </summary>
        /// <param name="vertexId">
        /// The vertex id.
        /// </param>
        public void AddNode(string vertexId)
        {
            if (this.graph != null)
            {
                this.graph.AddNode(vertexId);
            }
        }

        /// <summary>
        /// The add node.
        /// </summary>
        /// <param name="vertexId">
        /// The vertex id.
        /// </param>
        /// <param name="mode">
        /// The mode.
        /// </param>
        public void AddNode(string vertexId, int mode)
        {
            if (this.graph != null)
            {
                this.graph.AddNode(vertexId, mode);
            }
        }

        /// <summary>
        /// The create new graph.
        /// </summary>
        public void CreateNewGraph()
        {
            this.graph = new Graph();
        }

        /// <summary>
        /// The dinitz blocking.
        /// </summary>
        /// <returns>
        /// Returns maximum flow calculated by Dinitz Blocking algorithm.
        /// </returns>
        public int DinitzBlocking()
        {
            return this.graph.DinitzBlockingMaximumFlow();
        }

        /// <summary>
        /// The edit edge.
        /// </summary>
        /// <param name="sourceVertexId">
        /// The source vertex id.
        /// </param>
        /// <param name="targetVertexId">
        /// The target vertex id.
        /// </param>
        /// <param name="flow">
        /// The flow.
        /// </param>
        public void EditEdge(string sourceVertexId, string targetVertexId, int flow)
        {
            if (this.graph != null)
            {
                this.graph.EditEdge(sourceVertexId, targetVertexId, flow);
            }
        }

        /// <summary>
        /// The edit node.
        /// </summary>
        /// <param name="oldVertexId">
        /// The old vertex id.
        /// </param>
        /// <param name="newVertexId">
        /// The new vertex id.
        /// </param>
        /// <param name="mode">
        /// The mode.
        /// </param>
        public void EditNode(string oldVertexId, string newVertexId, int mode)
        {
            GraphNode graphNode = this.graph.Nodes.FindByName(oldVertexId);
            if (graphNode == null)
            {
                return;
            }

            graphNode.VertexId = newVertexId;
            if (mode == 0)
            {
                if (graphNode.NodeMode == 1)
                {
                    this.graph.EraseSourceNode();
                }

                if (graphNode.NodeMode == 2)
                {
                    this.graph.EraseSinkNode();
                }

                graphNode.NodeMode = 0;
            }

            if (mode == 1)
            {
                this.graph.SetSourceNode(newVertexId);
            }

            if (mode == 2)
            {
                this.graph.SetSinkNode(newVertexId);
            }
        }

        /// <summary>
        /// The edmonds karp.
        /// </summary>
        /// <returns>
        /// Returns maximum flow calculated by Edmonds-Karp algorithm.
        /// </returns>
        public int EdmondsKarp()
        {
            return this.graph.EdmondsKarpMaximumFlow();
        }

        /// <summary>
        /// The export graph to xml.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        public void ExportGraphToXml(string fileName)
        {
            var dataProvider = new DataProvider();
            dataProvider.ExportGraphToXml(this.graph, fileName);
        }

        /// <summary>
        /// The export results to xml.
        /// </summary>
        /// <param name="filePath">
        /// The file path.
        /// </param>
        public void ExportResultsToXml(string filePath)
        {
            var dataProvider = new DataProvider();
            dataProvider.ExportResultsToXml(this.graph, filePath);
        }

        /// <summary>
        /// The ford fulkerson.
        /// </summary>
        /// <returns>
        /// Returns maximum flow calculated by Ford-Fulkerson algorithm.
        /// </returns>
        public int FordFulkerson()
        {
            return this.graph.FordFulkersonMaximumFlow();
        }

        /// <summary>
        /// The get node mode.
        /// </summary>
        /// <param name="vertexId">
        /// The vertex id.
        /// </param>
        /// <returns>
        /// Returns NodeMode (source, normal, sink).
        /// </returns>
        public int GetNodeMode(string vertexId)
        {
            GraphNode graphNode = this.graph.Nodes.FindByName(vertexId);
            return graphNode.NodeMode;
        }

        /// <summary>
        /// The load from xml.
        /// </summary>
        /// <param name="filePath">
        /// The file path.
        /// </param>
        public void LoadFromXml(string filePath)
        {
            var dataProvider = new DataProvider();
            if (this.graph == null)
            {
                this.CreateNewGraph();
            }

            this.graph = dataProvider.LoadGraphFromXml(filePath);
        }

        /// <summary>
        /// The remove edge.
        /// </summary>
        /// <param name="startingVertexId">
        /// The starting vertex id.
        /// </param>
        /// <param name="targetVertexId">
        /// The target vertex id.
        /// </param>
        /// <returns>
        /// Returns true if given edge was removed false otherwise.
        /// </returns>
        public bool RemoveEdge(string startingVertexId, string targetVertexId)
        {
            if (this.graph == null)
            {
                return false;
            }

            if (this.graph.RemoveEdge(startingVertexId, targetVertexId))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// The remove node.
        /// </summary>
        /// <param name="vertexId">
        /// The vertex id.
        /// </param>
        /// <returns>
        /// Returns true if given node was removed false otherwise.
        /// </returns>
        public bool RemoveNode(string vertexId)
        {
            if (this.graph == null)
            {
                return false;
            }

            if (this.graph.RemoveNode(vertexId))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// The reset graph.
        /// </summary>
        public void ResetGraph()
        {
            if (this.graph != null)
            {
                this.graph.ResetGraph();
            }
        }

        /// <summary>
        /// The step by step dinitz blocking.
        /// </summary>
        /// <returns>
        /// Returns partial flow calculated by one step of Dinitz Blocking algorithm.
        /// </returns>
        public int StepByStepDinitzBlocking()
        {
            return this.graph.StepByStepDinitzBlockingMaximumFlow();
        }

        /// <summary>
        /// The step by step edmonds karp.
        /// </summary>
        /// <returns>
        /// Returns partial flow calculated by one step of Edmonds-Karp algorithm.
        /// </returns>
        public int StepByStepEdmondsKarp()
        {
            return this.graph.StepByStepEdmondsKarpMaximumFlow();
        }

        /// <summary>
        /// The step by step ford fulkerson.
        /// </summary>
        /// <returns>
        /// Returns partial flow calculated by one step of Ford-Fulkerson algorithm.
        /// </returns>
        public int StepByStepFordFulkerson()
        {
            return this.graph.StepByStepFordFulkersonMaximumFlow();
        }

        #endregion
    }
}