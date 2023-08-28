using System.ComponentModel.DataAnnotations;

namespace MinimalAPI7.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(10000)]
        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt;

        public DateTime UpdatedAt;
    }
}
