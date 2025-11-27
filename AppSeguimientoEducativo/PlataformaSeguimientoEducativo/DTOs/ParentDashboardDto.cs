using System.Text.Json.Serialization;

namespace PlataformaSeguimientoEducativo.DTOs
{
    public record ParentDashboardDto
    {
        [JsonPropertyName("parentId")]
        public int ParentId { get; init; }

        [JsonPropertyName("parentName")]
        public required string ParentName { get; init; }

        [JsonPropertyName("parentRole")]
        public required string ParentRole { get; init; }

        [JsonPropertyName("students")]
        public required List<StudentInfoDto> Students { get; init; }
    }
}