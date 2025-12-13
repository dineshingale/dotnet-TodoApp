using System.ComponentModel.DataAnnotations;

namespace MyTodoApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
    }
}