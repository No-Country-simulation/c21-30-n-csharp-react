using System.Diagnostics;
using System;
using System.ComponentModel.DataAnnotations;


namespace PlataformaSeguimientoEducativo.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public required string CourseName { get; set; }
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public int AcademicPeriodId { get; set; }
        public AcademicPeriod? AcademicPeriod { get; set; }
        public required string Grade { get; set; }
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
