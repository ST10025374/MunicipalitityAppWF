using System;

namespace MunicipalitityProgPoePart1.Classes
{
    // IComparable is a Comparison method for ordering or sorting its intances. 
    public class ServiceRequest : IComparable<ServiceRequest> 
    {
        /// <summary>
        /// Unique identifier for the service request.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        ///  Date the request was submitted.
        /// </summary>
        public DateTime DateSubmitted { get; set; }

        /// <summary>
        /// Current status of the request (e.g., "In Progress").
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        ///  A brief description of the request.
        /// </summary>
        public string Description { get; set; }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="status"></param>
        /// <param name="description"></param>
        public ServiceRequest(int id, DateTime date, string status, string description)
        {
            ID = id;
            DateSubmitted = date;
            Status = status;
            Description = description;
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Enables comparison of ServiceRequest objects for sorting/searching.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(ServiceRequest other)
        {
            return ID.CompareTo(other.ID);
        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 