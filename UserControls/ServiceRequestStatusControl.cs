using MunicipalitityProgPoePart1.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalitityProgPoePart1.UserControls
{
    public partial class ServiceRequestStatusControl : UserControl
    {
        /// <summary>
        /// A binary search tree (BST) is being used for storing and retrieving service requests by unique IDs.
        /// </summary>
        private ServiceRequestBST serviceRequestBST = new ServiceRequestBST();
        /// <summary>
        /// // A graph structure is used to track dependencies between service requests.
        /// </summary>
        private ServiceGraph serviceGraph = new ServiceGraph();

        //---------------------------------------------------------------------//
        /// <summary>
        /// Default Constructor
        /// Load some initial data into the BST and UI for testing
        /// </summary>
        public ServiceRequestStatusControl()
        {
            InitializeComponent();
            LoadSampleData();     
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Loads predefined sample data into the system for demonstration purposes.
        /// Adds service requests to both the BST and the ListView, and initializes dependencies in the graph.
        /// Sample service requests to be inserted into the system.
        /// Insert each sample request into the BST and ListView, and establish dependencies in the graph.
        /// Add the request to the BST.
        /// Display the request in the ListView.
        /// Define dependencies (edges in the graph).
        /// </summary>
        private void LoadSampleData()
        {
            try
            {              
                List<ServiceRequest> sampleRequests = new List<ServiceRequest>
                {
                    new ServiceRequest(14, DateTime.Now.AddDays(-8), "In Progress", "Park cleanup and maintenance"),
                    new ServiceRequest(15, DateTime.Now.AddDays(-6), "Completed", "Traffic light repair at 5th Avenue"),
                    new ServiceRequest(16, DateTime.Now.AddDays(-1), "Pending", "Tree trimming near Oak Street"),
                    new ServiceRequest(17, DateTime.Now.AddDays(-2), "Pending", "Pothole repair on Elm Road"),
                    new ServiceRequest(18, DateTime.Now.AddDays(-12), "Pending", "Storm drain cleaning in downtown area"),
                    new ServiceRequest(19, DateTime.Now.AddDays(-3), "Pending", "Sidewalk repair near City Hall"),
                };
      
                foreach (var request in sampleRequests)
                {
                    serviceRequestBST.Insert(request);        
                    AddRequestToListView(request);          
                }

                // Define dependencies (edges in the graph)
                serviceGraph.AddEdge(14, 15); 
                serviceGraph.AddEdge(15, 16);
                serviceGraph.AddEdge(16, 17); 
                serviceGraph.AddEdge(17, 18);
                serviceGraph.AddEdge(18, 19);
                serviceGraph.AddEdge(19, 20);
            }
            catch (Exception ex)
            {          
                MessageBox.Show("Error loading sample data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Create a new ListViewItem to represent the service request in the UI.
        /// A method that  adds a service request to the ListView UI for user visibility.
        /// Display the unique ID of the service request.
        /// Show the submission date in a readable format.
        /// Indicate the current status of the request.
        /// Include a brief description of the request.
        /// Add the item to the ListView.
        /// </summary>
        /// <param name="request">The service request to be added.</param>
        private void AddRequestToListView(ServiceRequest request)
        {
            var listViewItem = new ListViewItem(new string[]
            {
                request.ID.ToString(),                      
                request.DateSubmitted.ToShortDateString(), 
                request.Status,                            
                request.Description                        
            });

            lstServiceRequests.Items.Add(listViewItem);     
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Button click event handler for the "Update Status" button.
        /// Handles the Search button click event.
        /// Searches the BST(binary search tree) for a service request with the specified ID.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int searchID))
            {
                var result = serviceRequestBST.Search(searchID);

                if (result != null)
                {
                    MessageBox.Show($"Service Request Found:\nID: {result.ID}\nStatus: {result.Status}\nDate: {result.DateSubmitted.ToShortDateString()}\nDescription: {result.Description}",
                                    "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Service Request not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Handles the Show Dependencies button click event.
        /// Displays the dependencies of a service request using the graph structure.
        /// Ensure the entered ID is a valid integer.
        /// Retrieve the dependencies of the specified service request.
        /// Clear the ListBox before adding new items.
        /// If dependencies exist, display them in the ListBox.
        /// If no dependencies are found, inform the user.
        /// If the input is invalid, prompt the user to enter a numeric ID
        /// Catch any unexpected errors while retrieving dependencies
        /// </summary>
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtSearch.Text, out int requestID))
                {
                    var dependencies = serviceGraph.GetDependencies(requestID);

                    lstDependencies.Items.Clear();

                    if (dependencies.Count > 0)
                    {
                        lstDependencies.Items.Add("Dependencies:");
                        lstDependencies.Items.AddRange(dependencies.Select(dep => $"Request ID: {dep}").ToArray());
                    }
                    else
                    {
                        lstDependencies.Items.Add("No dependencies found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving dependencies: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Method to handle the "Show Graph" button click event.
        /// Clear the panel before drawing
        /// Get the graphics object for drawing
        /// Define basic styles
        /// Define positions for nodes (simple circular layout for now)
        /// Calculate node position based on circular layou
        /// Draw edges (dependencies)
        /// Draw nodes
        /// </summary>
        private void DrawGraph()
        {
            pnlGraph.Refresh();

            Graphics g = pnlGraph.CreateGraphics();
            Font font = new Font("Arial", 10);
            Brush nodeBrush = Brushes.CornflowerBlue;
            Pen edgePen = new Pen(Color.Black, 2);
            Dictionary<int, Point> nodePositions = new Dictionary<int, Point>();

            int centerX = pnlGraph.Width / 2;
            int centerY = pnlGraph.Height / 2;
            int radius = 100; 
            int angleStep = 360 / serviceGraph.AdjacencyList.Count; 
            int angle = 0;

            foreach (var node in serviceGraph.AdjacencyList.Keys)
            {
                int x = centerX + (int)(radius * Math.Cos(angle * Math.PI / 180));
                int y = centerY + (int)(radius * Math.Sin(angle * Math.PI / 180));

                nodePositions[node] = new Point(x, y);
                angle += angleStep;
            }

            foreach (var fromNode in serviceGraph.AdjacencyList.Keys)
            {
                foreach (var toNode in serviceGraph.AdjacencyList[fromNode])
                {
                    if (nodePositions.ContainsKey(fromNode) && nodePositions.ContainsKey(toNode))
                    {
                        g.DrawLine(edgePen, nodePositions[fromNode], nodePositions[toNode]); // Draw edge
                    }
                }
            }

            foreach (var node in nodePositions.Keys)
            {
                Point pos = nodePositions[node];
                g.FillEllipse(nodeBrush, pos.X - 20, pos.Y - 20, 40, 40); // Node size = 40x40
                g.DrawString(node.ToString(), font, Brushes.White, pos.X - 10, pos.Y - 10); // Draw ID inside
            }
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Method to handle the "Draw Graph" button click event.
        /// Call the graph drawing method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDrawGraph_Click(object sender, EventArgs e)
        {
            DrawGraph(); 
        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 