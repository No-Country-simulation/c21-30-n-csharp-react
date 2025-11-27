using System;
using System.ComponentModel.DataAnnotations;


namespace PlataformaSeguimientoEducativo.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User? User { get; set; }
        public string? Grade { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
        public ICollection<ParentStudent> ParentStudents { get; set; } = new List<ParentStudent>();
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
