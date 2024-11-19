namespace MunicipalitityProgPoePart1.Classes
{
    public class IssueClass
    {
        /// <summary>
        /// Stores the Location of the issue
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Stores the Category of the issue
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Stores the Description of the issue
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Stores the file path of the associated file.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Stores the file name of the associated file.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Stores the file data as a byte array.
        /// </summary>
        public byte[] FileData { get; set; }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Default Constructor
        /// </summary>
        public IssueClass()
        {

        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 