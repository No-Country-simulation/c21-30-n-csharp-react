using System;
using System.ComponentModel.DataAnnotations;


namespace PlataformaSeguimientoEducativo.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public required string Subject { get; set; }
        public DateTime HireDate { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
