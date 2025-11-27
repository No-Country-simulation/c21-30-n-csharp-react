﻿using PlataformaSeguimientoEducativo.DTOs;

namespace PlataformaSeguimientoEducativo.DTOs
{
	public record AcademicPeriodDto(int AcademicPeriodId, string PeriodName, List<CourseDto> Courses);
}