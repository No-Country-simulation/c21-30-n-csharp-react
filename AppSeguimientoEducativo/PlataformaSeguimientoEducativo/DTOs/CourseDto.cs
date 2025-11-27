using System.Text.Json.Serialization;

namespace PlataformaSeguimientoEducativo.DTOs
{
    public record CourseDto
    {
        [JsonPropertyName("courseId")]
        public int CourseId { get; init; }

        [JsonPropertyName("courseName")]
        public required string CourseName { get; init; }

        [JsonPropertyName("teachers")]
        public required List<TeacherInfoDto> Teachers { get; init; }
    }
}

