namespace MunicipalitityProgPoePart1.Classes
{
    public class ServiceRequestBST
    {
        /// <summary>
        /// The root node of the tree.
        /// </summary>
        private BSTNode root;

        //---------------------------------------------------------------------//
        /// <summary>
        /// Inserts a new service request into the BST.
        /// </summary>
        /// <param name="request"></param>
        public void Insert(ServiceRequest request)
        {
            root = InsertRecord(root, request);
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Recursive insertion helper method.
        /// Insert into the left subtree
        /// Insert into the right subtree.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        private BSTNode InsertRecord(BSTNode node, ServiceRequest request)
        {
            if (node == null) return new BSTNode(request);

            if (request.CompareTo(node.Data) < 0)
                node.Left = InsertRecord(node.Left, request); 
            else if (request.CompareTo(node.Data) > 0)
                node.Right = InsertRecord(node.Right, request); 

            return node;
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Searches the BST for a service request by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ServiceRequest Search(int id)
        {
            return SearchRecord(root, id);
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Recursive search helper method
        /// Base case: Not found
        /// Search in left subtree
        /// Search in right subtree
        /// </summary>
        /// <param name="node"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private ServiceRequest SearchRecord(BSTNode node, int id)
        {
            if (node == null) return null;  

            if (id == node.Data.ID) return node.Data;
            if (id < node.Data.ID) return SearchRecord(node.Left, id); 
            return SearchRecord(node.Right, id); 
        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 