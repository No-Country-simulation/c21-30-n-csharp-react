using System.Text.Json.Serialization;

namespace PlataformaSeguimientoEducativo.DTOs
{
    public record StudentDashboardDto
    {
        [JsonPropertyName("studentId")]
        public int StudentId { get; init; }

        [JsonPropertyName("studentName")]
        public required string StudentName { get; init; }

        [JsonPropertyName("tutor")]
        public Dictionary<string, string> Tutor { get; init; } = new();

        [JsonPropertyName("Courses")]
        public required List<CourseDto> Courses { get; init; }
    }
}
