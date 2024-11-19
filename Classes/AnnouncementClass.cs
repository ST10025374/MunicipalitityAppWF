using System;

namespace MunicipalitityProgPoePart1.Classes
{
    public class AnnouncementClass
    {
        /// <summary>
        /// Stores the title of the announcement
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Stores the description of the announcement
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Stores the date of the announcement
        /// </summary>
        public DateTime Date { get; set; }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Constructor to initialize a new announcement with validation
        /// </summary>
        /// <param name="title">Announcement title</param>
        /// <param name="description">Announcement description</param>
        /// <param name="date">Announcement date</param>
        public AnnouncementClass(string title, string description, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Announcement title cannot be empty.");

            if (date < DateTime.Now)
                throw new ArgumentException("Announcement date cannot be in the past.");

            Title = title;
            Description = description;
            Date = date;
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Override ToString to display announcement summary
        /// </summary>
        /// <returns>Formatted string with announcement title and date</returns>
        public override string ToString()
        {
            return $"{Title} on {Date.ToShortDateString()}";
        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 