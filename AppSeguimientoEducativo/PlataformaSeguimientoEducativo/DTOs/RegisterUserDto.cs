using System.ComponentModel.DataAnnotations;

namespace PlataformaSeguimientoEducativo.DTOs
{
    public record RegisterUserDto
    {
        [Required(ErrorMessage = "El nombre completo es requerido.")]
        public required string FullName { get; init; }

        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "Direccion de email invalido.")]
        public required string Email { get; init; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "La contraseña tiene que tener un minimo de 6 caracteres.")]
        public required string Password { get; init; }

        [Required(ErrorMessage = "El Rol es requerido.")]
        public required string RoleName { get; init; }
    }
}