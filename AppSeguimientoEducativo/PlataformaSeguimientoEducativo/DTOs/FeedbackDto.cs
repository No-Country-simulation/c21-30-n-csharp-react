namespace PlataformaSeguimientoEducativo.DTOs
{
    public record FeedbackDto(
        string FeedbackText, 
        string TeacherName, 
        string TeacherProfileImageUrl, 
        string Subject, 
        DateTime FeedbackDate, 
        decimal GradeValue
    );
}
