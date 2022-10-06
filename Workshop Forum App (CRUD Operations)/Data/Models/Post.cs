using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Workshop_Forum_App__CRUD_Operations_.Data.Models
{
    [Comment("Published posts")]
    public class Post
    {
        [Comment("Posts Identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Post title")]
        [Required]
        [MaxLength(50)] 
        public string Title { get; set; } = null!;

        [Comment("Content")]
        [Required]
        [MaxLength(1500)]
        public string Content { get; set; } = null!;

        [Comment("Shows if it's deleted")]
        [Required]
        public bool IsDeleted { get; set; } = false;
    }
}
