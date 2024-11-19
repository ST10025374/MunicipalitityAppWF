using System;

namespace MunicipalitityProgPoePart1.Classes
{
    public class EventClass
    {
        /// <summary>
        /// Stores the name of the event
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Stores the date of the event
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Stores the category of the event
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Stores the location of the event
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Stores the description of the event
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Stores the image path of the event
        /// </summary>
        public string ImagePath { get; set; }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Constructor to initialize a new event with validation
        /// </summary>
        /// <param name="name">Event name</param>
        /// <param name="date">Event date</param>
        /// <param name="category">Event category</param>
        /// <param name="location">Event location</param>
        /// <param name="description">Event description</param>
        public EventClass(string name, DateTime date, string category, string location, string description, string imagePath)
        {
            Name = name;
            Date = date;
            Category = category;
            Location = location;
            Description = description;
            ImagePath = imagePath;
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Override ToString to display event summary
        /// </summary>
        /// <returns>Formatted string with event name and date</returns>
        public override string ToString()
        {
            return $"{Name} on {Date.ToShortDateString()}";
        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 