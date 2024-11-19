using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MunicipalitityProgPoePart1.Classes;

namespace MunicipalitityProgPoePart1.UserControls
{
    public partial class EventsAndAnnouncementsControl : UserControl
    {
        /// <summary>
        /// Stack to store events
        /// </summary>
        private Stack<EventClass> eventStack = new Stack<EventClass>();

        /// <summary>
        /// Queue to store announcements
        /// </summary>
        private Queue<AnnouncementClass> announcementQueue = new Queue<AnnouncementClass>();

        /// <summary>
        /// Sorted dictionary to store events by date
        /// </summary>
        private SortedDictionary<DateTime, EventClass> sortedEvents = new SortedDictionary<DateTime, EventClass>();

        //---------------------------------------------------------------------//
        /// <summary>
        /// Initializes a new instance of the <see cref="EventsAndAnnouncementsControl"/> class.
        /// </summary>
        public EventsAndAnnouncementsControl()
        {
            InitializeComponent();
            LoadData();
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Loads sample data into the event stack, announcement queue, and sorted events dictionary.
        /// </summary>
        private void LoadData()
        {
            var sampleEvents = new List<EventClass>
            {
                new EventClass("Cleanup Drive", DateTime.Now.AddDays(3), "Environment", "Central Park", "A community event focused on cleaning up the park.", "Images/cleanup_drive"),
                new EventClass("Health Fair", DateTime.Now.AddDays(10), "Health", "Community Center", "Free health checkups and wellness resources.", "Images/Health Fair"),
                new EventClass("Local Farmers Market", DateTime.Now.AddDays(5), "Commerce", "Downtown Plaza", "Support local farmers and artisans at this weekly market.", "Local Farmers Market"),
                new EventClass("Town Hall Meeting", DateTime.Now.AddDays(7), "Governance", "City Hall", "Discuss upcoming projects with local government officials.", "Images/Town Hall Meeting"),
                new EventClass("Cultural Festival", DateTime.Now.AddDays(14), "Culture", "Riverside Park", "Celebrate the rich cultural heritage of our community.", "Images/Cultural Festival"),
                new EventClass("Recycling Awareness", DateTime.Now.AddDays(10), "Environment", "Recycling Center", "Learn about new recycling guidelines and sustainable practices.", "Images/Recycling Awareness"),
                new EventClass("Blood Donation Camp", DateTime.Now.AddDays(7), "Health", "Health Center", "Donate blood and save lives.", "Images/Blood Donation Camp")
            };

            var sampleAnnouncements = new List<AnnouncementClass>
            {
                new AnnouncementClass("Water Supply Maintenance", "Water will be unavailable in some areas for scheduled maintenance.", DateTime.Now.AddDays(1)),
                new AnnouncementClass("New Park Opening", "Join us for the grand opening of Greenfield Park!", DateTime.Now.AddDays(7)), 
                new AnnouncementClass("Free Vaccination Day", "Free vaccines will be available for all residents at City Hall.", DateTime.Now.AddDays(10)),
                new AnnouncementClass("Recycling Update", "Learn about changes to recycling guidelines at the Community Center.", DateTime.Now.AddDays(3)), 
                new AnnouncementClass("Library Renovation", "The public library will be closed for renovations from next week.", DateTime.Now.AddDays(6)),
                new AnnouncementClass("Food Truck Festival", "Enjoy a variety of food trucks at Downtown Square this Saturday.", DateTime.Now.AddDays(9)), 
                new AnnouncementClass("Neighborhood Watch Meeting", "Meeting to discuss community safety and updates.", DateTime.Now.AddDays(4))
            };

            foreach (var evt in sampleEvents)
            {
                eventStack.Push(evt);
                sortedEvents[evt.Date] = evt;
                lstEvents.Items.Add(evt.Name);
            }

            foreach (var ann in sampleAnnouncements)
            {
                announcementQueue.Enqueue(ann);
                lstAnnouncements.Items.Add(ann.Title);
            }

            PopulateCategoryComboBox();
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Event and Announcement selection and display methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEvents.SelectedIndex != -1)
            {
                var eventName = lstEvents.SelectedItem.ToString();
                var selectedEvent = sortedEvents.Values.FirstOrDefault(ev => ev.Name == eventName);

                if (selectedEvent != null)
                {
                    rtbDisplay.Text = $"{selectedEvent.Name}\n" +
                                           $"Date: {selectedEvent.Date}\n" +
                                           $"Location: {selectedEvent.Location}\n" +
                                           $"Description: {selectedEvent.Description}";
                }
            }

            //// Code didnt work as expected, so I commented it out (But i will still work on it for part 3)
            //if (lstEvents.SelectedIndex != -1)
            //{
            //    var eventName = lstEvents.SelectedItem.ToString();
            //    var selectedEvent = sortedEvents.Values.FirstOrDefault(ev => ev.Name == eventName);

            //    if (selectedEvent != null)
            //    {
            //        // Set up text to display
            //        string displayText = $"{selectedEvent.Name}\nDate: {selectedEvent.Date.ToShortDateString()}\nLocation: {selectedEvent.Location}\nDescription: {selectedEvent.Description}";

            //        // Load the image and create a Bitmap for drawing
            //        if (!string.IsNullOrEmpty(selectedEvent.ImagePath) && File.Exists(selectedEvent.ImagePath))
            //        {
            //            using (Image backgroundImage = Image.FromFile(selectedEvent.ImagePath))
            //            {
            //                Bitmap bitmap = new Bitmap(backgroundImage.Width, backgroundImage.Height);

            //                using (Graphics g = Graphics.FromImage(bitmap))
            //                {
            //                    // Draw the background image
            //                    g.DrawImage(backgroundImage, 0, 0, bitmap.Width, bitmap.Height);

            //                    // Set up font and text color
            //                    Font font = new Font("Arial", 14, FontStyle.Bold);
            //                    Brush textBrush = new SolidBrush(Color.White);

            //                    // Calculate the text position
            //                    PointF textPosition = new PointF(10, 10);

            //                    // Draw the text on the image
            //                    g.DrawString(displayText, font, textBrush, textPosition);
            //                }

            //                // Display the combined image and text in the PictureBox
            //                pbDisplay.Image = bitmap;
            //                pbDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            //            }
            //        }
            //        else
            //        {
            //            // Clear the PictureBox if no image is found
            //            pbDisplay.Image = null;
            //        }
            //    }
            //}
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Handles the event when an announcement is selected from the list.
        /// Updates the announcement details in the rich text box.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void lstAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAnnouncements.SelectedIndex != -1)
            {
                var announcementTitle = lstAnnouncements.SelectedItem.ToString();
                var selectedAnnouncement = announcementQueue.FirstOrDefault(ann => ann.Title == announcementTitle);

                if (selectedAnnouncement != null)
                {
                    rtbDisplay.Text = $"{selectedAnnouncement.Title}\n" +
                                                  $"Date: {selectedAnnouncement.Date}\n" +
                                                  $"Description: {selectedAnnouncement.Description}";
                }
            }
        }
        
        //---------------------------------------------------------------------//
        /// <summary>
        /// Populates the category combo box with event categories.
        /// </summary>
        private void PopulateCategoryComboBox()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.Add("All");

            foreach (var evt in sortedEvents.Values)
            {
                if (!cboCategory.Items.Contains(evt.Category))
                {
                    cboCategory.Items.Add(evt.Category);
                }
            }

            cboCategory.SelectedIndex = 0;
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Searches events based on the specified category and date.
        /// </summary>
        /// <param name="category">The category to filter events by. Use "All" to include all categories.</param>
        /// <param name="date">The date to filter events by. Use DateTime.MinValue to include all dates.</param>
        private void SearchEvents(string category, DateTime date)
        {
            lstEvents.Items.Clear(); 

            foreach (var evt in sortedEvents.Values)
            {
                bool matchesCategory = category == "All" || evt.Category == category;
                bool matchesDate = date == DateTime.MinValue || evt.Date.Date == date.Date;

                if (matchesCategory && matchesDate)
                {
                    lstEvents.Items.Add(evt.Name); 
                }
            }
            if (lstEvents.Items.Count == 0)
                lstEvents.Items.Add("No events found for selected criteria.");
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Button to go back to the previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoBack2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Button to search for events based on category and date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedCategory = cboCategory.SelectedItem != null ? cboCategory.SelectedItem.ToString() : "All";
            DateTime selectedDate = dtpEventDate.Value;

            SearchEvents(selectedCategory, selectedDate);
        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 