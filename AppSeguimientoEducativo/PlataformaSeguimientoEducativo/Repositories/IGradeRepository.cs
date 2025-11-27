using PlataformaSeguimientoEducativo.Models;

namespace PlataformaSeguimientoEducativo.Repositories;

public interface IGradeRepository : IRepository<Grade>
{
    Task<List<Grade>> GetGradesByStudentId(int studentId, int? courseId, int? AcademicPeriodId);
    Task<Grade> AddGradesAsync(Grade grade);
    Task<Grade?> GetGradesByIdAsync(int gradeId);
    Task<Grade> UpdateGradesAsync(Grade grade);
}