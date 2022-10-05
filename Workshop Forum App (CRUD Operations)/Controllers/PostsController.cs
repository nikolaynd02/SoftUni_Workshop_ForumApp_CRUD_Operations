using Microsoft.AspNetCore.Mvc;
using Workshop_Forum_App__CRUD_Operations_.Data;
using Workshop_Forum_App__CRUD_Operations_.Models;

namespace Workshop_Forum_App__CRUD_Operations_.Controllers
{
    public class PostsController : Controller
    {
        private readonly ForumAppDbContext context;

        public PostsController(ForumAppDbContext context) => this.context = context;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult All()
        {
            var posts = this.context
                .Posts
                .Select(p => new PostViewModel()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content,
                })
                .ToList();

            return View(posts);
        }
    }
}
