namespace PlataformaSeguimientoEducativo.DTOs
{
    public record CourseInfoDto(
        int CourseId, 
        string CourseName, 
        string TeacherName, 
        string ProfileImagenUrl, 
        string Subject, 
        string AcademicPeriodName, 
        List<GradeDto> Grades, 
        List<FeedbackDto> Feedbacks
    );
}
