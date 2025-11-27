using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaSeguimientoEducativo.Models

{
    public class AcademicPeriod
    {
        public int AcademicPeriodId { get; set; }
        public required string PeriodName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public required ICollection<Course> Courses { get; set; }
    }
}
