// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GraphNodeList.cs" company="Warsaw University of Technology">
//   Piotr Janaszek
// </copyright>
// <summary>
//   Class responsible for keeping neighbours of the vertex.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetworkFlow.Provider.BLL
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// Class responsible for keeping neighbours of the vertex.
    /// </summary>
    public class GraphNodeList : Collection<GraphNode>
    {
        #region Public Methods and Operators

        /// <summary>
        /// The find by name.
        /// </summary>
        /// <param name="name">
        /// The vertex name.
        /// </param>
        /// <returns>
        /// Returns node if vertex with given name was found, null otherwise.
        /// </returns>
        public GraphNode FindByName(string name)
        {
            foreach (GraphNode node in this.Items)
            {
                if (node.VertexId.Equals(name))
                {
                    return node;
                }
            }

            return null;
        }

        #endregion
    }
}