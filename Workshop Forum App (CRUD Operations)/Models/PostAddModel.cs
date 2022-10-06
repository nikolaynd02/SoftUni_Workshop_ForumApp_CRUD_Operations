using System.ComponentModel.DataAnnotations;

namespace Workshop_Forum_App__CRUD_Operations_.Models
{
    public class PostAddModel
    {
        [Required]
        [StringLength(50, MinimumLength = 10)]
        public string Title { get; set; }

        [Required]
        [StringLength(1500, MinimumLength = 30)]
        public string Content { get; set; }
    }
}
