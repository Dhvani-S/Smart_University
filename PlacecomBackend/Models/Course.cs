using System;
using System.Collections.Generic;

namespace PlacecomBackend.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Instructor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Navigation properties
        public ICollection<Student> EnrolledStudents { get; set; } = new List<Student>();
    }
}
