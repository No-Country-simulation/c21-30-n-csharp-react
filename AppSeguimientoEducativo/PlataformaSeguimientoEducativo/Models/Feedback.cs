using System;
using System.ComponentModel.DataAnnotations;


namespace PlataformaSeguimientoEducativo.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public required string FeedbackText { get; set; }
        public DateTime FeedbackDate { get; set; }
    }
}
