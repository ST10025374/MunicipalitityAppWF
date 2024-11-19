using System.Collections.Generic;

namespace MunicipalitityProgPoePart1.Classes
{
    public class ServiceGraph
    {
        /// <summary>
        /// Dictionary that stores the graph as an adjacency list.
        /// </summary>
        private Dictionary<int, List<int>> adjacencyList;

        //---------------------------------------------------------------------//
        /// <summary>
        /// Provides public access to the adjacency list, which represents the graph of dependencies.
        /// Each key in the dictionary represents a service request ID, and the corresponding value
        /// is a list of IDs that the request depends on.
        /// </summary>
        public Dictionary<int, List<int>> AdjacencyList
        {
            get { return adjacencyList; }
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Method to initialize the adjacency list, which is a dictionary used to represent the graph.
        /// The keys in the dictionary are service request IDs (int),
        /// and the values are lists of integers representing dependencies (connected nodes).
        /// </summary>
        public ServiceGraph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Adds a directed edge between two service requests.
        /// Add the dependency
        /// </summary>
        public void AddEdge(int requestID1, int requestID2)
        {
            if (!adjacencyList.ContainsKey(requestID1))
                adjacencyList[requestID1] = new List<int>();

            adjacencyList[requestID1].Add(requestID2);
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// List that retrieves the dependencies of a given service request.
        /// </summary>
        public List<int> GetDependencies(int requestID)
        {
            return adjacencyList.ContainsKey(requestID) 
                ? adjacencyList[requestID] : new List<int>();
        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 