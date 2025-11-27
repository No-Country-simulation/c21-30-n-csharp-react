using System.Text.Json.Serialization;

namespace PlataformaSeguimientoEducativo.DTOs
{
    public record PeriodDto
    {
        [JsonPropertyName("periodName")]
        public required string PeriodName { get; init; }

        [JsonPropertyName("Courses")]
        public required List<CourseDto> Courses { get; init; }
    }
}
