using Microsoft.AspNetCore.Mvc;
using Workshop_Forum_App__CRUD_Operations_.Data;
using Workshop_Forum_App__CRUD_Operations_.Data.Models;
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
                .Where(p => p.IsDeleted == false)
                .Select(p => new PostViewModel()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content,
                })
                .ToList();

            return View(posts);
        }

        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(PostAddModel model)
        {
            var post = new Post()
            {
                Title = model.Title,
                Content = model.Content
            };

            this.context.Posts.Add(post);
            this.context.SaveChanges();

            return RedirectToAction("All");
        }

        public IActionResult Edit(int id)
        {
            var post = this.context.Posts.Find(id);

            return View(new PostAddModel()
            {
                Title = post.Title,
                Content = post.Content
            });
        }

        [HttpPost]
        public IActionResult Edit(int id, PostAddModel model)
        {
            var post = this.context.Posts.Find(id);
            post.Title = model.Title;
            post.Content = model.Content;

            this.context.SaveChanges();

            return RedirectToAction("All");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var post = this.context.Posts.Find(id);

            post.IsDeleted = true;
            this.context.SaveChanges();

            return RedirectToAction("All");
        }
    }
}
