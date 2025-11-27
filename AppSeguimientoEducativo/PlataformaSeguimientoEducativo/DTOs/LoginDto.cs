using System.ComponentModel.DataAnnotations;

namespace PlataformaSeguimientoEducativo.DTOs
{
    public record LoginDto
    {
        [Required]
        [EmailAddress]
        public required string Email { get; init; }

        [Required]
        public required string Password { get; init; }
    }
}
