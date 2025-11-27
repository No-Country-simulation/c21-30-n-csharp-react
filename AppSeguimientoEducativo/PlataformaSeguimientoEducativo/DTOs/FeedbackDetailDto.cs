using System.Text.Json.Serialization;

namespace PlataformaSeguimientoEducativo.DTOs
{
    public record FeedbackDetailDto
    {
        [JsonPropertyName("feedbackText")]
        public required string FeedbackText { get; init; }

        [JsonPropertyName("feedbackDate")]
        public required string FeedbackDate { get; init; }
    }
}
