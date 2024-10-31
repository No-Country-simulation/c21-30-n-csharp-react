﻿using PlataformaSeguimientoEducativo.Services;

namespace PlataformaSeguimientoEducativo.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IRoleRepository Roles { get; }
        IStudentRepository Students { get; }
        ICourseRepository Courses { get; }
        IParentRepository Parents { get; }
        IGradeRepository Grades { get; }
        ITeacherRepository Teachers { get; }
        IFeedbackRepository Feedbacks { get; }
        Task<int> CompleteAsync();
    }
}