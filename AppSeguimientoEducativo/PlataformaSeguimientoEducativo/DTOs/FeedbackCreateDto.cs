namespace PlataformaSeguimientoEducativo.DTOs
{
    public record FeedbackCreateDto(
        int FeedbackId, 
        int StudentId, 
        int TeacherId, 
        int CourseId, 
        string FeedbackText, 
        DateTime FeedbackDate
    );
}
