using System.Collections.Generic;

namespace PlacecomBackend.Models
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string EstablishedYear { get; set; }
        public string Website { get; set; }

        // Navigation properties
        public ICollection<Student> EnrolledStudents { get; set; } = new List<Student>();
    }
}
