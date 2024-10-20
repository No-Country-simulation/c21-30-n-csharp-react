﻿using PlataformaSeguimientoEducativo.DTOs; // Aquí estarán los DTOs de Grade (como GradeDto)

namespace PlataformaSeguimientoEducativo.Services
{
	public interface IGradeService
	{
		Task<IEnumerable<GradeDto>> GetGradesByStudentIdAsync(int studentId);
	}
}