// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Graph.cs" company="Warsaw University of Technology">
//   Piotr Janaszek
// </copyright>
// <summary>
//   Class responsible for holding and managing a graph.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetworkFlow.Provider.BLL
{
    using System.Collections.Generic;

    /// <summary>
    /// Class responsible for holding and managing a graph.
    /// </summary>
    public class Graph
    {
        #region Constants and Fields

        /// <summary>
        ///   The node set.
        /// </summary>
        private readonly GraphNodeList nodeSet;

        /// <summary>
        /// The edges.
        /// </summary>
        private int edges;

        /// <summary>
        /// The max flow.
        /// </summary>
        private int maxFlow;

        /// <summary>
        /// The sink.
        /// </summary>
        private GraphNode sink;

        /// <summary>
        /// The source.
        /// </summary>
        private GraphNode source;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Graph"/> class. 
        /// </summary>
        public Graph()
            : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Graph"/> class. 
        /// </summary>
        /// <param name="nodeSet">
        /// The node set. 
        /// </param>
        public Graph(GraphNodeList nodeSet)
        {
            this.nodeSet = this.nodeSet == null ? new GraphNodeList() : nodeSet;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///   Gets Count.
        /// </summary>
        public int Count
        {
            get
            {
                return this.nodeSet.Count;
            }
        }

        /// <summary>
        /// Gets Edges.
        /// </summary>
        public int Edges
        {
            get
            {
                return this.edges;
            }
        }

        /// <summary>
        /// Gets MaximumFlow.
        /// </summary>
        public int MaximumFlow
        {
            get
            {
                return this.maxFlow;
            }
        }

        /// <summary>
        ///   Gets Nodes.
        /// </summary>
        public GraphNodeList Nodes
        {
            get
            {
                return this.nodeSet;
            }
        }

        /// <summary>
        ///   Gets Sink.
        /// </summary>
        public string Sink
        {
            get
            {
                return this.sink != null ? this.sink.VertexId : null;
            }

            private set
            {
                GraphNode graphNode = this.nodeSet.FindByName(value);
                if (graphNode != null)
                {
                    this.sink = graphNode;
                }
            }
        }

        /// <summary>
        ///   Gets Source.
        /// </summary>
        public string Source
        {
            get
            {
                return this.source != null ? this.source.VertexId : null;
            }

            private set
            {
                GraphNode graphNode = this.nodeSet.FindByName(value);
                if (graphNode != null)
                {
                    this.source = graphNode;
                }
            }
        }

        #endregion

        #region Methods

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
        internal void AddDirectedEdge(GraphNode from, GraphNode to, int flow)
        {
            var edge = new GraphEdge
                {
                    NodeFrom = @from, 
                    NodeTo = to, 
                    Capacity = flow, 
                    MaxCapacity = flow, 
                    IsResidual = false, 
                    IsVisible = true
                };
            from.Neighbours.Add(edge);
            GraphEdge edgeResidual = to.Neighbours.FindByName(to.VertexId, from.VertexId);
            if (edgeResidual == null)
            {
                var edgeRes = new GraphEdge
                    {
                       NodeFrom = to, NodeTo = @from, Capacity = 0, IsResidual = true, IsVisible = true 
                    };
                to.Neighbours.Add(edgeRes);
            }

            this.edges++;
        }

        /// <summary>
        /// The add node.
        /// </summary>
        /// <param name="node">
        /// The node. 
        /// </param>
        internal void AddNode(string node)
        {
            this.nodeSet.Add(new GraphNode(node));
        }

        /// <summary>
        /// The add node method taking VertexId and nodeMode.
        /// </summary>
        /// <param name="node">
        /// The node. 
        /// </param>
        /// <param name="nodeMode">
        /// The node mode. 
        /// </param>
        internal void AddNode(string node, int nodeMode)
        {
            this.nodeSet.Add(new GraphNode(node, nodeMode));
            if (nodeMode == 1)
            {
                this.SetSourceNode(node);
            }

            if (nodeMode == 2)
            {
                this.SetSinkNode(node);
            }
        }

        /// <summary>
        /// The add node.
        /// </summary>
        /// <param name="node">
        /// The node. 
        /// </param>
        internal void AddNode(GraphNode node)
        {
            int nodeMode = node.NodeMode;
            this.nodeSet.Add(node);
            if (nodeMode == 1)
            {
                this.SetSourceNode(node.VertexId);
            }

            if (nodeMode == 2)
            {
                this.SetSinkNode(node.VertexId);
            }
        }

        /// <summary>
        /// The contains.
        /// </summary>
        /// <param name="vertexId">
        /// The vertex id. 
        /// </param>
        /// <returns>
        /// Returns true if node with given vertexId was found, false otherwise. 
        /// </returns>
        internal bool Contains(string vertexId)
        {
            return this.nodeSet.FindByName(vertexId) != null;
        }

        /// <summary>
        /// The dinitz blocking maximum flow.
        /// </summary>
        /// <returns>
        /// Returns maximum flow value.
        /// </returns>
        internal int DinitzBlockingMaximumFlow()
        {
            var work = true;
            while (work)
            {
                this.SetVisible();
                work = this.BreadthFirstSearchDinitzBlocking(this.source, this.sink);
                this.BuildLayerdGraph();
                GraphEdgeList path = this.DepthFirstSearch(this.source, this.sink);
                while (path != null && path.Count > 0)
                {
                    int minCapacity = int.MaxValue;
                    foreach (GraphEdge edge in path)
                    {
                        if (edge.Capacity < minCapacity)
                        {
                            minCapacity = edge.Capacity;
                        }
                    }

                    this.AugumentPath(path, minCapacity);
                    this.maxFlow += minCapacity;
                    path = this.DepthFirstSearch(this.source, this.sink);
                }
            }

            return this.maxFlow;
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
        /// <param name="capacity">
        /// The max flow.
        /// </param>
        internal void EditEdge(string sourceVertexId, string targetVertexId, int capacity)
        {
            GraphNode startingNode = this.nodeSet.FindByName(sourceVertexId);
            GraphEdge edgeToEdit = startingNode.Neighbours.FindByName(sourceVertexId, targetVertexId);
            if (edgeToEdit != null)
            {
                edgeToEdit.Capacity = capacity;
            }
        }

        /// <summary>
        /// The edmonds karp maximum flow.
        /// </summary>
        /// <returns>
        /// Returns maximum flow value.
        /// </returns>
        internal int EdmondsKarpMaximumFlow()
        {
            this.ResetGraph();
            GraphEdgeList path = this.BreadthFirstSearch(this.source, this.sink);
            while (path != null && path.Count > 0)
            {
                int minCapacity = int.MaxValue;
                foreach (GraphEdge edge in path)
                {
                    if (edge.Capacity < minCapacity)
                    {
                        minCapacity = edge.Capacity;
                    }
                }

                this.AugumentPath(path, minCapacity);
                this.maxFlow += minCapacity;
                path = this.BreadthFirstSearch(this.source, this.sink);
            }

            return this.maxFlow;
        }

        /// <summary>
        /// The ford fulkerson maximum flow.
        /// </summary>
        /// <returns>
        /// Returns maximum flow found by Ford Fulkerson algorithm.
        /// </returns>
        internal int FordFulkersonMaximumFlow()
        {
            this.ResetGraph();
            GraphEdgeList path = this.DepthFirstSearch(this.source, this.sink);
            while (path != null && path.Count > 0)
            {
                int minCapacity = int.MaxValue;
                foreach (GraphEdge edge in path)
                {
                    if (edge.Capacity < minCapacity)
                    {
                        minCapacity = edge.Capacity;
                    }
                }

                this.AugumentPath(path, minCapacity);
                this.maxFlow += minCapacity;
                path = this.DepthFirstSearch(this.source, this.sink);
            }

            return this.maxFlow;
        }

        /// <summary>
        /// The remove edge.
        /// </summary>
        /// <param name="sourceVertexId">
        /// The source vertex id.
        /// </param>
        /// <param name="targetVertexId">
        /// The target vertex id.
        /// </param>
        /// <returns>
        /// Returns true if edge was successfully removed, false otherwise.
        /// </returns>
        internal bool RemoveEdge(string sourceVertexId, string targetVertexId)
        {
            GraphNode startingNode = this.nodeSet.FindByName(sourceVertexId);
            GraphEdge edgeToRemove = startingNode.Neighbours.FindByName(sourceVertexId, targetVertexId);
            if (edgeToRemove == null)
            {
                return false;
            }

            startingNode.Neighbours.Remove(edgeToRemove);
            this.edges--;
            return true;
        }

        /// <summary>
        /// The remove node.
        /// </summary>
        /// <param name="vertexId">
        /// The vertex id.
        /// </param>
        /// <returns>
        /// Returns true if node was successfully removed, false otherwise.
        /// </returns>
        internal bool RemoveNode(string vertexId)
        {
            GraphNode nodeToRemove = this.nodeSet.FindByName(vertexId);
            if (nodeToRemove == null)
            {
                return false;
            }

            this.nodeSet.Remove(nodeToRemove);
            foreach (GraphNode gnode in this.nodeSet)
            {
                var index = new List<int>();
                for (int i = 0; i < gnode.Neighbours.Count; i++)
                {
                    if (gnode.Neighbours[i].NodeTo == nodeToRemove)
                    {
                        index.Insert(0, i);
                    }

                    if (gnode.Neighbours[i].NodeFrom == nodeToRemove)
                    {
                        index.Insert(0, i);
                    }
                }

                foreach (int i in index)
                {
                    gnode.Neighbours.RemoveAt(i);
                }
            }

            return true;
        }

        /// <summary>
        /// The reset graph.
        /// </summary>
        internal void ResetGraph()
        {
            this.maxFlow = 0;
            foreach (GraphNode gnode in this.nodeSet)
            {
                foreach (GraphEdge neighbour in gnode.Neighbours)
                {
                    neighbour.Capacity = neighbour.MaxCapacity;
                    neighbour.IsVisible = true;
                }

                gnode.TraverseParent = null;
            }
        }

        /// <summary>
        /// The set sink node.
        /// </summary>
        /// <param name="vertexId">
        /// The vertex id.
        /// </param>
        internal void SetSinkNode(string vertexId)
        {
            foreach (GraphNode node in this.nodeSet)
            {
                if (node.NodeMode == 2)
                {
                    node.NodeMode = 0;
                }

                if (node.VertexId.Equals(vertexId))
                {
                    node.NodeMode = 2;
                    this.Sink = node.VertexId;
                }
            }
        }

        /// <summary>
        /// The set source node.
        /// </summary>
        /// <param name="vertexId">
        /// The vertex id.
        /// </param>
        internal void SetSourceNode(string vertexId)
        {
            foreach (GraphNode node in this.nodeSet)
            {
                if (node.NodeMode == 1)
                {
                    node.NodeMode = 0;
                }

                if (node.VertexId.Equals(vertexId))
                {
                    node.NodeMode = 1;
                    this.Source = node.VertexId;
                }
            }
        }

        /// <summary>
        /// The step by step dinitz blocking maximum flow.
        /// </summary>
        /// <returns>
        /// Returns partial maximum flow.
        /// </returns>
        internal int StepByStepDinitzBlockingMaximumFlow()
        {
            this.SetVisible();
            bool work = this.BreadthFirstSearchDinitzBlocking(this.source, this.sink);
            if (work)
            {
                this.BuildLayerdGraph();
                GraphEdgeList path = this.DepthFirstSearch(this.source, this.sink);
                while (path != null && path.Count > 0)
                {
                    int minCapacity = int.MaxValue;
                    foreach (GraphEdge edge in path)
                    {
                        if (edge.Capacity < minCapacity)
                        {
                            minCapacity = edge.Capacity;
                        }
                    }

                    this.AugumentPath(path, minCapacity);
                    this.maxFlow += minCapacity;
                    path = this.DepthFirstSearch(this.source, this.sink);
                }

                return this.maxFlow;
            }

            return -1;
        }

        /// <summary>
        /// The step by step edmonds karp maximum flow.
        /// </summary>
        /// <returns>
        /// Returns partial maximum flow.
        /// </returns>
        internal int StepByStepEdmondsKarpMaximumFlow()
        {
            GraphEdgeList path = this.BreadthFirstSearch(this.source, this.sink);
            if (path != null && path.Count > 0)
            {
                int minCapacity = int.MaxValue;
                foreach (GraphEdge edge in path)
                {
                    if (edge.Capacity < minCapacity)
                    {
                        minCapacity = edge.Capacity;
                    }
                }

                this.AugumentPath(path, minCapacity);
                this.maxFlow += minCapacity;
                return this.maxFlow;
            }

            return -1;
        }

        /// <summary>
        /// The step by step ford fulkerson maximum flow.
        /// </summary>
        /// <returns>
        /// Returns partial maximum flow.
        /// </returns>
        internal int StepByStepFordFulkersonMaximumFlow()
        {
            GraphEdgeList path = this.DepthFirstSearch(this.source, this.sink);
            if (path != null && path.Count > 0)
            {
                int minCapacity = int.MaxValue;
                foreach (GraphEdge edge in path)
                {
                    if (edge.Capacity < minCapacity)
                    {
                        minCapacity = edge.Capacity;
                    }
                }

                this.AugumentPath(path, minCapacity);
                this.maxFlow += minCapacity;
                return this.maxFlow;
            }

            return -1;
        }

        /// <summary>
        /// The augument path.
        /// </summary>
        /// <param name="path">
        /// The path.
        /// </param>
        /// <param name="minCapacity">
        /// The min capacity.
        /// </param>
        private void AugumentPath(IEnumerable<GraphEdge> path, int minCapacity)
        {
            foreach (GraphEdge edge in path)
            {
                GraphEdge edgeResidual = this.GetResidualEdge(edge);
                edge.Capacity -= minCapacity;
                edgeResidual.Capacity += minCapacity;
            }
        }

        /// <summary>
        /// The breadth first search.
        /// </summary>
        /// <param name="root">
        /// The root.
        /// </param>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <returns>
        /// Returns GraphEdgeList path found by Breadth First Search algorithm.
        /// </returns>
        private GraphEdgeList BreadthFirstSearch(GraphNode root, GraphNode target)
        {
            root.TraverseParent = null;
            target.TraverseParent = null;
            var queue = new Queue<GraphNode>();
            var discovered = new HashSet<GraphNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                GraphNode current = queue.Dequeue();
                discovered.Add(current);
                if (current == target)
                {
                    return this.GetPath(current);
                }

                GraphEdgeList neighbours = current.Neighbours;
                foreach (GraphEdge neighbour in neighbours)
                {
                    GraphNode next = neighbour.NodeTo;
                    if (neighbour.Capacity > 0 && !discovered.Contains(next))
                    {
                        next.TraverseParent = current;
                        queue.Enqueue(next);
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// The breadth first search dinitz blocking.
        /// </summary>
        /// <param name="root">
        /// The root.
        /// </param>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <returns>
        /// Returns true if there is a path from source to sink, false otherwise.
        /// </returns>
        private bool BreadthFirstSearchDinitzBlocking(GraphNode root, GraphNode target)
        {
            root.TraverseParent = null;
            target.TraverseParent = null;
            var queue = new Queue<GraphNode>();
            var discovered = new HashSet<GraphNode>();
            var distance = new HashSet<GraphNode>();
            queue.Enqueue(root);
            root.Distance = 0;
            while (queue.Count > 0)
            {
                GraphNode current = queue.Dequeue();
                discovered.Add(current);
                if (current == target)
                {
                    return true;
                }

                GraphEdgeList neighbours = current.Neighbours;
                foreach (GraphEdge neighbour in neighbours)
                {
                    if (!neighbour.IsVisible)
                    {
                        continue;
                    }

                    GraphNode next = neighbour.NodeTo;
                    if (neighbour.Capacity > 0 && !discovered.Contains(next))
                    {
                        next.TraverseParent = current;
                        if (!distance.Contains(next))
                        {
                            next.Distance = current.Distance + 1;
                            distance.Add(next);
                        }

                        queue.Enqueue(next);
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// The build layerd graph.
        /// </summary>
        private void BuildLayerdGraph()
        {
            foreach (GraphNode node in this.nodeSet)
            {
                foreach (GraphEdge neighbour in node.Neighbours)
                {
                    if (neighbour.NodeTo.Distance == node.Distance)
                    {
                        neighbour.IsVisible = false;
                    }
                }
            }
        }

        /// <summary>
        /// The depth first search.
        /// </summary>
        /// <param name="root">
        /// The root.
        /// </param>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <returns>
        /// Returns GraphEdgeList path found by Depth First Search algorithm.
        /// </returns>
        private GraphEdgeList DepthFirstSearch(GraphNode root, GraphNode target)
        {
            root.TraverseParent = null;
            target.TraverseParent = null;
            var stack = new Stack<GraphNode>();
            var discovered = new HashSet<GraphNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                GraphNode current = stack.Pop();
                discovered.Add(current);
                if (current == target)
                {
                    return this.GetPath(current);
                }

                GraphEdgeList neighbours = current.Neighbours;
                foreach (GraphEdge neighbour in neighbours)
                {
                    if (neighbour.IsVisible == false)
                    {
                        continue;
                    }

                    GraphNode next = neighbour.NodeTo;
                    if (neighbour.Capacity > 0 && !discovered.Contains(next))
                    {
                        next.TraverseParent = current;
                        stack.Push(next);
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// The get path.
        /// </summary>
        /// <param name="node">
        /// The node.
        /// </param>
        /// <returns>
        /// Returns GraphEdgeList path from source to sink.
        /// </returns>
        private GraphEdgeList GetPath(GraphNode node)
        {
            var path = new GraphEdgeList();
            GraphNode current = node;
            while (current.TraverseParent != null)
            {
                GraphEdge edge = current.TraverseParent.Neighbours.FindByName(
                    current.TraverseParent.VertexId, current.VertexId);
                path.Insert(0, edge);

                // path.Add(edge);
                current = current.TraverseParent;
            }

            return path;
        }

        /// <summary>
        /// The GetResidualEdge method.
        /// </summary>
        /// <param name="edge">
        /// The edge.
        /// </param>
        /// <returns>
        /// Returns GraphEdge object which is a residual edge to given edge.
        /// </returns>
        private GraphEdge GetResidualEdge(GraphEdge edge)
        {
            GraphNode gnode = this.nodeSet.FindByName(edge.NodeTo.VertexId);
            GraphEdge edgeResidual = gnode.Neighbours.FindByName(edge.NodeTo.VertexId, edge.NodeFrom.VertexId);
            return edgeResidual;
        }

        /// <summary>
        /// The set visible.
        /// </summary>
        private void SetVisible()
        {
            foreach (GraphNode node in this.nodeSet)
            {
                foreach (GraphEdge neighbour in node.Neighbours)
                {
                    if (neighbour.Capacity == 0)
                    {
                        neighbour.IsVisible = false;
                    }

                    neighbour.IsVisible = true;
                }
            }
        }

        #endregion
    }
}