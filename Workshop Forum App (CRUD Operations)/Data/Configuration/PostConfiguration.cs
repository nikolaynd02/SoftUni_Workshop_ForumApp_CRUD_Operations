using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Workshop_Forum_App__CRUD_Operations_.Data.Models;

namespace Workshop_Forum_App__CRUD_Operations_.Data.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            List<Post> posts = GetPosts();

            builder.HasData(posts);
        }

        private List<Post> GetPosts()
        {
            return new List<Post>()
            {
                new Post()
                {
                    Id = 1,
                    Title = "My First Post",
                    Content = "My first post will be about performing CRUD operations in MVC. It's so much fun!"
                },
                new Post()
                {
                    Id = 2,
                    Title = "My Second Post",
                    Content = "My second post will be about performing CRUD operations in MVC. It's so much fun!"
                },
                new Post()
                {
                    Id = 3,
                    Title = "My Third Post",
                    Content = "My third post will be about performing CRUD operations in MVC. It's so much fun!"
                }
            };
        }
    }
}
