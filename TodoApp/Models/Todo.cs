using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public enum Priority
    {
        Important,
        Urgent,
    }
    public class Todo
    {
        [Key, Required]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Title { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string Description { get; set; } = string.Empty;
        public Priority Priority { get; set; } = Priority.Important;
        public bool IsCompleted { get; set; } = false;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

         [Required]
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
