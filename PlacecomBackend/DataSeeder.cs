using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlacecomBackend.Models;

namespace PlacecomBackend
{
    public class DataSeeder
    {
        public static void SeedData(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (context.Students.Any() || context.Courses.Any() || context.JobApplications.Any())
                {
                    // Data already seeded
                    return;
                }

                // Sample student data
                var students = new[]
                {
                    new Student
                    {
                        FirstName = "Aarav",
                        LastName = "Verma",
                        DateOfBirth = new DateTime(1997, 8, 12),
                        Email = "aarav@example.com",
                        PhoneNumber = "123-456-7890",
                        Major = "Computer Science",
                        WorkExperience = "24"
                    },

                    new Student
                    {
                        FirstName = "Neha",
                        LastName = "Srivastava",
                        DateOfBirth = new DateTime(1999, 3, 15),
                        Email = "neha@example.com",
                        PhoneNumber = "234-567-8901",
                        Major = "Electrical Engineering",
                        WorkExperience = "8"
                    },

                    new Student
                    {
                        FirstName = "Rahul",
                        LastName = "Gupta",
                        DateOfBirth = new DateTime(1998, 6, 2),
                        Email = "rahul@example.com",
                        PhoneNumber = "345-678-9012",
                        Major = "Mechanical Engineering",
                        WorkExperience = "16"
                    },

                    new Student
                    {
                        FirstName = "Sneha",
                        LastName = "Patel",
                        DateOfBirth = new DateTime(2000, 1, 9),
                        Email = "sneha@example.com",
                        PhoneNumber = "456-789-0123",
                        Major = "Medicine",
                        WorkExperience = "6"
                    },

                    new Student
                    {
                        FirstName = "Vivek",
                        LastName = "Kumar",
                        DateOfBirth = new DateTime(1997, 11, 25),
                        Email = "vivek@example.com",
                        PhoneNumber = "567-890-1234",
                        Major = "Civil Engineering",
                        WorkExperience = "20"
                    },

                    new Student
                    {
                        FirstName = "Ananya",
                        LastName = "Sharma",
                        DateOfBirth = new DateTime(1999, 7, 7),
                        Email = "ananya@example.com",
                        PhoneNumber = "678-901-2345",
                        Major = "Architecture",
                        WorkExperience = "12"
                    },

                    new Student
                    {
                        FirstName = "Amit",
                        LastName = "Singh",
                        DateOfBirth = new DateTime(2001, 4, 18),
                        Email = "amit@example.com",
                        PhoneNumber = "789-012-3456",
                        Major = "Economics",
                        WorkExperience = "4"
                    },

                    new Student
                    {
                        FirstName = "Ishita",
                        LastName = "Mishra",
                        DateOfBirth = new DateTime(1998, 9, 30),
                        Email = "ishita@example.com",
                        PhoneNumber = "890-123-4567",
                        Major = "Psychology",
                        WorkExperience = "14"
                    },

                    new Student
                    {
                        FirstName = "Ravi",
                        LastName = "Verma",
                        DateOfBirth = new DateTime(2000, 2, 5),
                        Email = "ravi@example.com",
                        PhoneNumber = "901-234-5678",
                        Major = "Literature",
                        WorkExperience = "7"
                    },

                    new Student
                    {
                        FirstName = "Priya",
                        LastName = "Agarwal",
                        DateOfBirth = new DateTime(1999, 10, 22),
                        Email = "priya@example.com",
                        PhoneNumber = "012-345-6789",
                        Major = "Political Science",
                        WorkExperience = "18"
                    },

                    new Student
                    {
                        FirstName = "Arjun",
                        LastName = "Pandey",
                        DateOfBirth = new DateTime(1997, 12, 1),
                        Email = "arjun@example.com",
                        PhoneNumber = "123-456-7890",
                        Major = "History",
                        WorkExperience = "22"
                    },

                    new Student
                    {
                        FirstName = "Sakshi",
                        LastName = "Choudhury",
                        DateOfBirth = new DateTime(1998, 4, 14),
                        Email = "sakshi@example.com",
                        PhoneNumber = "234-567-8901",
                        Major = "Chemistry",
                        WorkExperience = "15"
                    },

                    new Student
                    {
                        FirstName = "Raj",
                        LastName = "Malhotra",
                        DateOfBirth = new DateTime(2001, 9, 9),
                        Email = "raj@example.com",
                        PhoneNumber = "345-678-9012",
                        Major = "Mathematics",
                        WorkExperience = "5"
                    },

                    new Student
                    {
                        FirstName = "Aisha",
                        LastName = "Ahmed",
                        DateOfBirth = new DateTime(1999, 1, 30),
                        Email = "aisha@example.com",
                        PhoneNumber = "456-789-0123",
                        Major = "Biology",
                        WorkExperience = "9"
                    },

                    new Student
                    {
                        FirstName = "Rohan",
                        LastName = "Joshi",
                        DateOfBirth = new DateTime(1998, 7, 20),
                        Email = "rohan@example.com",
                        PhoneNumber = "567-890-1234",
                        Major = "Physics",
                        WorkExperience = "17"
                    },

                    new Student
                    {
                        FirstName = "Smita",
                        LastName = "Desai",
                        DateOfBirth = new DateTime(2000, 3, 12),
                        Email = "smita@example.com",
                        PhoneNumber = "678-901-2345",
                        Major = "Sociology",
                        WorkExperience = "11"
                    },

                    new Student
                    {
                        FirstName = "Vikram",
                        LastName = "Prasad",
                        DateOfBirth = new DateTime(1997, 11, 5),
                        Email = "vikram@example.com",
                        PhoneNumber = "789-012-3456",
                        Major = "Anthropology",
                        WorkExperience = "21"
                    },

                    new Student
                    {
                        FirstName = "Mitali",
                        LastName = "Gandhi",
                        DateOfBirth = new DateTime(1999, 5, 17),
                        Email = "mitali@example.com",
                        PhoneNumber = "890-123-4567",
                        Major = "Geography",
                        WorkExperience = "13"
                    },

                    new Student
                    {
                        FirstName = "Aryan",
                        LastName = "Saxena",
                        DateOfBirth = new DateTime(2001, 2, 8),
                        Email = "aryan@example.com",
                        PhoneNumber = "901-234-5678",
                        Major = "Philosophy",
                        WorkExperience = "6"
                    },

                    new Student
                    {
                        FirstName = "Nisha",
                        LastName = "Gupta",
                        DateOfBirth = new DateTime(1998, 10, 23),
                        Email = "nisha@example.com",
                        PhoneNumber = "012-345-6789",
                        Major = "Linguistics",
                        WorkExperience = "19"
                    },

                    new Student
                    {
                        FirstName = "Rajat",
                        LastName = "Sharma",
                        DateOfBirth = new DateTime(1997, 6, 15),
                        Email = "rajat@example.com",
                        PhoneNumber = "123-456-7890",
                        Major = "Environmental Science",
                        WorkExperience = "23"
                    },

                    new Student
                    {
                        FirstName = "Kavya",
                        LastName = "Rai",
                        DateOfBirth = new DateTime(1999, 12, 10),
                        Email = "kavya@example.com",
                        PhoneNumber = "234-567-8901",
                        Major = "Journalism",
                        WorkExperience = "7"
                    },

                    new Student
                    {
                        FirstName = "Vishal",
                        LastName = "Parekh",
                        DateOfBirth = new DateTime(1998, 3, 28),
                        Email = "vishal@example.com",
                        PhoneNumber = "345-678-9012",
                        Major = "Music",
                        WorkExperience = "16"
                    },

                    new Student
                    {
                        FirstName = "Sanya",
                        LastName = "Mukherjee",
                        DateOfBirth = new DateTime(2000, 8, 6),
                        Email = "sanya@example.com",
                        PhoneNumber = "456-789-0123",
                        Major = "Drama",
                        WorkExperience = "10"
                    },

                    new Student
                    {
                        FirstName = "Rahul",
                        LastName = "Kapoor",
                        DateOfBirth = new DateTime(1999, 4, 27),
                        Email = "rahul@example.com",
                        PhoneNumber = "567-890-1234",
                        Major = "Fine Arts",
                        WorkExperience = "14"
                    },

                    // Add more sample students here...
                };
                context.Students.AddRange(students);
                context.SaveChanges();

                //Courses data
                 var courses = new[]
                {
                    new Course
                    {
                        Name = "Artificial Intelligence",
                        Description = "Explore the world of AI and machine learning.",
                        Instructor = "Dr. Jane Smith",
                        StartDate = new DateTime(2023, 9, 1),
                        EndDate = new DateTime(2023, 12, 15)
                    },
                    new Course
                    {
                        Name = "Digital Marketing",
                        Description = "Learn strategies for promoting products online.",
                        Instructor = "John Doe",
                        StartDate = new DateTime(2023, 10, 1),
                        EndDate = new DateTime(2023, 12, 31)
                    },
                    new Course
                    {
                        Name = "Sports Management",
                        Description = "Combine your passion for sports with business skills.",
                        Instructor = "Sarah Johnson",
                        StartDate = new DateTime(2023, 9, 15),
                        EndDate = new DateTime(2023, 11, 30)
                    }
                };
                context.Courses.AddRange(courses);
                context.SaveChanges();

                 var jobApplications = new[]
                {
                    new JobApplication
                    {
                        Position = "Software Developer",
                        Company = "Tech Solutions Inc.",
                        RequiredWorkExperience = 24,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Digital Marketing Specialist",
                        Company = "Digital Marketing Agency",
                        RequiredWorkExperience = 12,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                    Position= "Software Developer",
                    Company= "Tech Solutions Inc.",
                    RequiredWorkExperience= 24,
                    Course=context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                    Position="Digital Marketing Specialist",
                    Company="Digital Marketing Agency",
                    RequiredWorkExperience= 12,
                    Course=context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                    Position= "Sports Event Coordinator",
                    Company="Sports Management Group",
                    RequiredWorkExperience= 18,
                    Course=context.Courses.FirstOrDefault(c => c.Name == "Sports Management")
                    },
                    new JobApplication
                    {
                        Position = "UX/UI Designer",
                        Company = "Design Innovators",
                        RequiredWorkExperience = 20,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Data Analyst",
                        Company = "Data Analytics Co.",
                        RequiredWorkExperience = 15,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Sales Executive",
                        Company = "Global Sales Corp.",
                        RequiredWorkExperience = 8,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Content Writer",
                        Company = "Content Creations Ltd.",
                        RequiredWorkExperience = 10,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "HR Manager",
                        Company = "HR Solutions Inc.",
                        RequiredWorkExperience = 30,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Financial Analyst",
                        Company = "Finance Experts Group",
                        RequiredWorkExperience = 22,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Event Planner",
                        Company = "Event Management Services",
                        RequiredWorkExperience = 16,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Frontend Developer",
                        Company = "Web Development Co.",
                        RequiredWorkExperience = 18,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Marketing Manager",
                        Company = "Marketing Producers Inc.",
                        RequiredWorkExperience = 25,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Project Manager",
                        Company = "Project Management Solutions",
                        RequiredWorkExperience = 28,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Customer Support Representative",
                        Company = "Customer Service Experts",
                        RequiredWorkExperience = 6,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Graphic Designer",
                        Company = "Creative Graphics Studio",
                        RequiredWorkExperience = 14,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Product Manager",
                        Company = "Product Innovations Co.",
                        RequiredWorkExperience = 32,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Network Engineer",
                        Company = "Networking Solutions Ltd.",
                        RequiredWorkExperience = 26,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },

                    new JobApplication
                    {
                        Position = "Legal Advisor",
                        Company = "Legal Consultants Group",
                        RequiredWorkExperience = 20,
                        Course=context.Courses.FirstOrDefault(c => c.Name == "Sports Management")
                    },
                    new JobApplication
                    {
                        Position = "Operations Manager",
                        Company = "Operations Excellence Corp.",
                        RequiredWorkExperience = 30,
                        Course=context.Courses.FirstOrDefault(c => c.Name == "Sports Management")
                    },
                    new JobApplication
                    {
                        Position = "Data Scientist",
                        Company = "Data Science Innovations",
                        RequiredWorkExperience = 28,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Video Editor",
                        Company = "Media Productions Ltd.",
                        RequiredWorkExperience = 10,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Quality Assurance Engineer",
                        Company = "QualityTech Solutions",
                        RequiredWorkExperience = 16,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Business Analyst",
                        Company = "Business Insights Group",
                        RequiredWorkExperience = 22,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Social Media Manager",
                        Company = "Social Connect Agency",
                        RequiredWorkExperience = 14,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "IT Support Specialist",
                        Company = "IT Services Co.",
                        RequiredWorkExperience = 12,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Supply Chain Manager",
                        Company = "Supply Chain Experts",
                        RequiredWorkExperience = 24,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "E-commerce Manager",
                        Company = "Online Retailers Inc.",
                        RequiredWorkExperience = 18,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Mechanical Engineer",
                        Company = "Engineering Innovations",
                        RequiredWorkExperience = 20,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Art Director",
                        Company = "Creative Art Studio",
                        RequiredWorkExperience = 14,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },

                    new JobApplication
                    {
                        Position = "Healthcare Administrator",
                        Company = "Healthcare Management Co.",
                        RequiredWorkExperience = 30,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Sports Management")
                    },
                    new JobApplication
                    {
                        Position = "Database Administrator",
                        Company = "Database Solutions Ltd.",
                        RequiredWorkExperience = 26,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Interior Designer",
                        Company = "Interior Concepts Studio",
                        RequiredWorkExperience = 12,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Technical Writer",
                        Company = "Tech Documentation Ltd.",
                        RequiredWorkExperience = 8,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Sports Management")
                    },
                    new JobApplication
                    {
                        Position = "Accountant",
                        Company = "Financial Services Group",
                        RequiredWorkExperience = 16,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Retail Store Manager",
                        Company = "Retail Excellence Corp.",
                        RequiredWorkExperience = 22,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Business Development Manager",
                        Company = "Business Growth Solutions",
                        RequiredWorkExperience = 24,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Civil Engineer",
                        Company = "Construction Engineers Inc.",
                        RequiredWorkExperience = 18,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Marketing Coordinator",
                        Company = "Marketing Strategies Co.",
                        RequiredWorkExperience = 10,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "IT Project Manager",
                        Company = "IT Project Management Co.",
                        RequiredWorkExperience = 28,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Research Analyst",
                        Company = "Research Insights Ltd.",
                        RequiredWorkExperience = 14,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Sports Management")
                    },
                    new JobApplication
                    {
                        Position = "Human Resources Coordinator",
                        Company = "HR Management Group",
                        RequiredWorkExperience = 12,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Web Developer",
                        Company = "Web Development Solutions",
                        RequiredWorkExperience = 20,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Logistics Coordinator",
                        Company = "Logistics Services Inc.",
                        RequiredWorkExperience = 16,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "IT Security Specialist",
                        Company = "Security Tech Solutions",
                        RequiredWorkExperience = 24,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Fashion Designer",
                        Company = "Fashion Innovations Co.",
                        RequiredWorkExperience = 14,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Product Marketing Manager",
                        Company = "Product Marketing Producers",
                        RequiredWorkExperience = 18,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Electrical Engineer",
                        Company = "Electrical Innovations Ltd.",
                        RequiredWorkExperience = 26,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Public Relations Specialist",
                        Company = "PR Strategies Group",
                        RequiredWorkExperience = 10,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Sports Management")
                    },
                    new JobApplication
                    {
                        Position = "System Administrator",
                        Company = "System Admin Solutions",
                        RequiredWorkExperience = 22,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Graphic Illustrator",
                        Company = "Illustration Studios Inc.",
                        RequiredWorkExperience = 12,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Business Consultant",
                        Company = "Business Insights Consultancy",
                        RequiredWorkExperience = 30,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "Software Tester",
                        Company = "Software Testing Solutions",
                        RequiredWorkExperience = 14,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Medical Coder",
                        Company = "Medical Coding Services",
                        RequiredWorkExperience = 16,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Procurement Manager",
                        Company = "Procurement Excellence Corp.",
                        RequiredWorkExperience = 20,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Digital Marketing")
                    },
                    new JobApplication
                    {
                        Position = "UX/UI Designer",
                        Company = "Design Innovators",
                        RequiredWorkExperience = 15,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Artificial Intelligence")
                    },
                    new JobApplication
                    {
                        Position = "Financial Analyst",
                        Company = "Financial Insights Group",
                        RequiredWorkExperience = 28,
                        Course = context.Courses.FirstOrDefault(c => c.Name == "Sports Management")
                    }

                };
                context.JobApplications.AddRange(jobApplications);
                context.SaveChanges();
                
            };
        }
    }
}
