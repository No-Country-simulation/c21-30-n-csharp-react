using System;

using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaSeguimientoEducativo.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public required string RoleName { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
