using System.Text.Json.Serialization;

namespace PlataformaSeguimientoEducativo.DTOs
{
    public record TeacherInfoDto
    {
        [JsonPropertyName("teacherName")]
        public required string TeacherName { get; init; }

        [JsonPropertyName("profileImageUrl")]
        public required string ProfileImageUrl { get; init; }

        [JsonPropertyName("subjectName")]
        public required string SubjectName { get; init; }

        [JsonPropertyName("period")]
        public required string Period { get; init; }

        [JsonPropertyName("gradeValue")]
        public decimal GradeValue { get; init; }

        [JsonPropertyName("feedback")]
        public required FeedbackDetailDto Feedback { get; init; }
    }
}
