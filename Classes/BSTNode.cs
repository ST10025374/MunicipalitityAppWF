namespace MunicipalitityProgPoePart1.Classes
{
    public class BSTNode
    {
        /// <summary>
        /// The service request stored in the node.
        /// </summary>
        public ServiceRequest Data { get; set; }
        /// <summary>
        /// Reference to the left child.
        /// </summary>
        public BSTNode Left { get; set; }
        /// <summary>
        /// Reference to the right child
        /// </summary>        
        public BSTNode Right { get; set; }

        //---------------------------------------------------------------------//
        /// <summary>
        /// constructor for the BSTNode
        /// Assign the input 'data' (a ServiceRequest object) to the node's 'Data' property.
        /// Initialize the left child of the node as null (no child initially).
        /// Initialize the right child of the node as null (no child initially).
        /// </summary>
        /// <param name="data"></param>
        public BSTNode(ServiceRequest data)
        {
            Data = data;   
            Left = null;   
            Right = null;  
        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 