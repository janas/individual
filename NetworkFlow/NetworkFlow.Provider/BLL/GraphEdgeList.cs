// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GraphEdgeList.cs" company="Warsaw University of Technology">
//   Piotr Janaszek
// </copyright>
// <summary>
//   Class responsible for keeping edges of the vertex.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetworkFlow.Provider.BLL
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// Class responsible for keeping edges of the vertex.
    /// </summary>
    public class GraphEdgeList : Collection<GraphEdge>
    {
        #region Public Methods and Operators

        /// <summary>
        /// The find by name.
        /// </summary>
        /// <param name="start">
        /// The start.
        /// </param>
        /// <param name="end">
        /// The end.
        /// </param>
        /// <returns>
        /// Returns GraphEdge if edge with given starting and ending vertex was found, null otherwise.
        /// </returns>
        public GraphEdge FindByName(string start, string end)
        {
            foreach (GraphEdge edge in this.Items)
            {
                if (edge.NodeFrom.VertexId.Equals(start) && edge.NodeTo.VertexId.Equals(end))
                {
                    return edge;
                }
            }

            return null;
        }

        #endregion
    }
}