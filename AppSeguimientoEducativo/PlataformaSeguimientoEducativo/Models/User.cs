namespace PlataformaSeguimientoEducativo.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public required string FullName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public required string Email { get; set; }

        public required string ProfileImageUrl { get; set; }

        [Required]
        public string? PasswordHash { get; set; }

        [Phone]
        [StringLength(20)]
        public string? PhoneNumber { get; set; }
        public int RoleId { get; set; }
        public Role? Role { get; set; }
        public Teacher? Teacher { get; set; }
        public ICollection<Communication> SentCommunications { get; set; } = new HashSet<Communication>();
        public ICollection<Communication> ReceivedCommunications { get; set; } = new HashSet<Communication>();
    }
}
