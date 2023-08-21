using System;

namespace PlacecomBackend.Models
{
    public class JobApplication
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CompanyId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public bool IsApproved { get; set; }
        public string CoverLetter { get; set; }
        
        // Additional properties
        public string Position { get; set; }
        public int RequiredWorkExperience { get; set; }

        // Foreign key for Course
        public int CourseId { get; set; }
        
        // Navigation properties
        public Student Student { get; set; }
        public Company Company { get; set; }
        public Course Course { get; set; }
    }
}
