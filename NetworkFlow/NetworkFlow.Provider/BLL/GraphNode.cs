// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GraphNode.cs" company="Warsaw University of Technology">
//   Piotr Janaszek
// </copyright>
// <summary>
//   Class responsible for handling node of a graph.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetworkFlow.Provider.BLL
{
    /// <summary>
    /// Class responsible for handling node of a graph.
    /// </summary>
    public class GraphNode
    {
        #region Constants and Fields

        /// <summary>
        /// The neighbours.
        /// </summary>
        private GraphEdgeList neighbours;

        #endregion

        #region Constructors and Destructors
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNode"/> class. 
        /// </summary>
        /// <param name="vertexId">
        /// The vertex id.
        /// </param>
        public GraphNode(string vertexId)
        {
            this.VertexId = vertexId;
            this.TraverseParent = null;
            this.NodeMode = 0;
            this.neighbours = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNode"/> class. 
        /// </summary>
        /// <param name="vertexId">
        /// The vertex id.
        /// </param>
        /// <param name="nodeMode">
        /// The node mode.
        /// </param>
        public GraphNode(string vertexId, int nodeMode)
        {
            this.VertexId = vertexId;
            this.TraverseParent = null;
            this.NodeMode = nodeMode;
            this.neighbours = null;
        }

        /// <summary> 
        /// Initializes a new instance of the <see cref="GraphNode"/> class.
        /// </summary>
        /// <param name="vertexId">
        /// The vertex id.
        /// </param>
        /// <param name="neighbours">
        /// The neighbours.
        /// </param>
        public GraphNode(string vertexId, GraphEdgeList neighbours)
        {
            this.VertexId = vertexId;
            this.TraverseParent = null;
            this.NodeMode = 0;
            this.neighbours = neighbours;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNode"/> class.
        /// </summary>
        /// <param name="vertexId">
        /// The vertex id.
        /// </param>
        /// <param name="neighbours">
        /// The neighbours.
        /// </param>
        /// <param name="nodeMode">
        /// The node mode.
        /// </param>
        public GraphNode(string vertexId, GraphEdgeList neighbours, int nodeMode)
        {
            this.VertexId = vertexId;
            this.TraverseParent = null;
            this.NodeMode = nodeMode;
            this.neighbours = neighbours;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets Neighbours.
        /// </summary>
        public GraphEdgeList Neighbours
        {
            get
            {
                if (this.neighbours == null)
                {
                    this.neighbours = new GraphEdgeList();
                }

                return this.neighbours;
            }
        }

        /// <summary>
        /// Gets or sets NodeMode.
        /// </summary>
        public int NodeMode { get; set; }

        /// <summary>
        /// Gets or sets TraverseParent.
        /// </summary>
        public GraphNode TraverseParent { get; set; }

        /// <summary>
        /// Gets or sets VertexID.
        /// </summary>
        public string VertexId { get; set; }

        #endregion
    }
}