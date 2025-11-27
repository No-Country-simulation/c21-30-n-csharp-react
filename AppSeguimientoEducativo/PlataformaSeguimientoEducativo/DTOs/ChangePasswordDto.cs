using System.ComponentModel.DataAnnotations;

namespace PlataformaSeguimientoEducativo.DTOs
{
    public record ChangePasswordDto
    {
        [Required]
        public required string CurrentPassword { get; init; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public required string NewPassword { get; init; }

        [Compare("NewPassword", ErrorMessage = "La nueva contraseña y la contraseña de confirmación no coinciden.")]
        public required string ConfirmNewPassword { get; init; }
    }
}
