using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class User
    {
        [Key, Required]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public ICollection<Todo> Todos { get; set; } = new List<Todo>();
    }
}
