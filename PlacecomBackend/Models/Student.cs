using System;
using System.Collections.Generic;

namespace PlacecomBackend.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Major { get; set; }
        public string WorkExperience { get; set; } // New property

        // Navigation properties
        public ICollection<Course> EnrolledCourses { get; set; } = new List<Course>();
        public ICollection<JobApplication> JobApplications { get; set; } = new List<JobApplication>();
        public ICollection<University> Universities { get; set; } = new List<University>();
    }
}
