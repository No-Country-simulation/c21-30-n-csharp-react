namespace PlataformaSeguimientoEducativo.DTOs{
    public record GradeDto(
        int CourseId, 
        string CourseName, 
        int PeriodId, 
        int GradeId, 
        decimal GradeValue, 
        DateTime EvaluationDate
    );
}