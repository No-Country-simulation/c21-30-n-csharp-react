using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaSeguimientoEducativo.Models
{
    public class ParentStudent
    {
        public int ParentStudentId { get; set; }
        public int ParentId { get; set; }
        public required Parent Parent { get; set; }
        public int StudentId { get; set; }
        public required Student Student { get; set; }
    }
}
