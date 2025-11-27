namespace PlataformaSeguimientoEducativo.DTOs
{
    public record CourseCreateDto(int Id, string CourseName, int TeacherId, int AcademicPeriodId, string Grade);
}
