using System.Collections.Generic;

namespace PlacecomBackend.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Industry { get; set; }
        public string Location { get; set; }
        public string Website { get; set; }

        // Navigation properties
        public ICollection<JobApplication> JobApplications { get; set; } = new List<JobApplication>();

        public static implicit operator Company(string v)
        {
            throw new NotImplementedException();
        }
    }
}
