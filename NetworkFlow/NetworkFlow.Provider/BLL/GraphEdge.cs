// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GraphEdge.cs" company="Warsaw University of Technology">
//   Piotr Janaszek
// </copyright>
// <summary>
//   Class responsible for handling edge of a graph.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NetworkFlow.Provider.BLL
{
    /// <summary>
    /// Class responsible for handling edge of a graph.
    /// </summary>
    public class GraphEdge
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets Capacity.
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// Gets or sets NodeFrom.
        /// </summary>
        public GraphNode NodeFrom { get; set; }

        /// <summary>
        /// Gets or sets NodeTo.
        /// </summary>
        public GraphNode NodeTo { get; set; }

        /// <summary>
        /// Gets or sets MaxCapacity.
        /// </summary>
        public int MaxCapacity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsResidual.
        /// </summary>
        public bool IsResidual { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsVisible.
        /// </summary>
        public bool IsVisible { get; set; }

        #endregion
    }
}